import React, { useState, useEffect } from 'react';
import { Button, Table, Modal, Form, Input, Select } from 'antd';
import { toast } from 'react-toastify';
import { useNavigate } from 'react-router-dom';
import {
  GetAllAccount,
  UpdateRole,
  ToggleAccountBannedStatus,
} from '../api/AccountApi'; // Adjust the import path as necessary
import 'react-toastify/dist/ReactToastify.css';
import { getJwtToken } from '../api/Url';

const { Option } = Select; // Destructure Option from Select

function AccountManager() {
  const [data, setData] = useState([]); // State to hold account data
  const [showForm, setShowForm] = useState(false);
  const [loading, setLoading] = useState(true);
  const [isToggling, setIsToggling] = useState(false);
  const [form] = Form.useForm();
  const [searchTerm, setSearchTerm] = useState(''); // State for search term
  const [filteredData, setFilteredData] = useState([]); // State for filtere
  const navigate = useNavigate(); // Initialize navigate for navigation


  // Define roles for the dropdown
  const roles = ['delivery staff', 'staff', 'customer', 'admin']; // Add your roles here
  // Function to check if the user is authorized
  const isAuthorized = () => {
    const token = getJwtToken();
    return token !== null; // Check if token exists
  };

  // Redirect to login if not authorized
  useEffect(() => {
    if (!isAuthorized()) {
      navigate('/login'); // Redirect to login page
    } else {
      fetchData(); // Fetch data if authorized
    }
  }, [navigate]); // Add navigate to the dependency array

  // Function to fetch account data
  const fetchData = async () => {
    setLoading(true); // Set loading to true while fetching
    try {
      const response = await GetAllAccount(); // Use the API function
      if (response && response.status === 200) {
        setData(response.data || []); // Set the fetched data directly
      }
    } catch (error) {
      console.error('Error fetching accounts:', error);
      toast.error("Error fetching accounts: " + error.message);
    } finally {
      setLoading(false); // Set loading to false after fetching
    }
  };

  // Handle search input change
  const handleSearchChange = (e) => {
    const value = e.target.value;
    setSearchTerm(value);
    searchAccountsByUsername(value); // Call search function
  };

  const searchAccountsByUsername = async (username) => {
    setLoading(true);
    try {
      const response = await GetAllAccount(); // Fetch all accounts
      if (response && response.status === 200) {
        const filtered = response.data.filter(account =>
          account.userName.toLowerCase().includes(username.toLowerCase())
        );
        setFilteredData(filtered); // Set filtered data
      }
    } catch (error) {
      console.error('Error searching accounts:', error);
      toast.error("Error searching accounts: " + error.message);
    } finally {
      setLoading(false);
    }
  };


  const handleEdit = async (values) => {
    try {
      const response = await UpdateRole(values.accountId, values.role); // Update role
      if (response) {
        toast.success("Account updated successfully!");
        setShowForm(false);
        fetchData(); // Refresh data after editing
      } else {
        toast.error("Failed to update account.");
      }
    } catch (error) {
      console.error('Error updating account:', error);
      toast.error("Error updating account: " + error.message);
    }
  };

  const toggleBannedStatus = async (record) => {
    if (isToggling || !record) return; // Prevent duplicate calls
    setIsToggling(true); // Disable further calls

    try {
      const newBannedStatus = !record.banned;
      const response = await ToggleAccountBannedStatus(record.accountId, newBannedStatus);
      if (response && response.status === 200) {
        toast.success(`Account ${newBannedStatus ? 'banned' : 'unbanned'} successfully!`);
        const updatedData = data.map(item =>
          item.accountId === record.accountId ? { ...item, banned: newBannedStatus } : item
        );
        setData(updatedData); // Update the state with the new data
        if (searchTerm) {
          const updatedFilteredData = filteredData.map(item =>
            item.accountId === record.accountId ? { ...item, banned: newBannedStatus } : item
          );
          setFilteredData(updatedFilteredData); // Update filtered data if searching
        }
      } else {
        toast.error("Failed to update banned status.");
      }
    } catch (error) {
      console.error('Error toggling banned status:', error);
      toast.error("Error toggling banned status: " + error.message);
    } finally {
      setIsToggling(false); // Re-enable the button after request is completed
    }
  };

  const columns = [
    { title: 'Account ID', dataIndex: 'accountId' },
    { title: 'Username', dataIndex: 'userName' },
    { title: 'Email', dataIndex: 'email' },
    { title: 'Role', dataIndex: 'role' },
    { title: 'Verified', dataIndex: 'verified', render: (verified) => (verified ? 'Yes' : 'No') },
    {
      title: 'Actions',
      render: (text, record) => (
        <>
          <Select
            defaultValue={record.role}
            style={{ width: 120 }}
            onChange={(value) => {
              // Update the role in the record and save changes
              handleEdit({ ...record, role: value }); // Ensure the role is updated
            }}
          >
            {roles.map(role => (
              <Option key={role} value={role}>{role}</Option>
            ))}
          </Select>
          <Button
            onClick={() => toggleBannedStatus(record)}
            disabled={isToggling}
            style={{
              marginLeft: '8px',
              backgroundColor: record.banned ? 'orange' : undefined,
            }}
          >
            {record.banned ? 'Unban' : 'Ban'}
          </Button>
        </>
      ),
    },
  ];

  return (

    <div>
      <h2>Manage Accounts</h2>
      <Input
        placeholder="Search by username"
        value={searchTerm}
        onChange={handleSearchChange}
        style={{ marginBottom: '16px' }}
      />
      <Table
        columns={columns}
        dataSource={searchTerm ? filteredData : data} // Use filtered data if searchTerm exists
        loading={loading} // Show loading state
        rowKey="accountId"
        pagination={{
          pageSize: 5,
          showSizeChanger: false,
        }}
      />
      {/* <Modal
        title={formData ? "Edit Account" : "Add Account"}
        open={showForm}
        onCancel={() => setShowForm(false)}
        footer={null}
      >
        <Form
          form={form}
          initialValues={formData || {}}
          onFinish={handleSubmit}
          layout="horizontal"
        >
          <Form.Item name="username" style={{ display: 'none' }} >
            <Input type="hidden" />
          </Form.Item>
          <Form.Item label="Phone" name="phone" rules={[{ required: true, message: 'Please input phone number!' }]}>
            <Input />
          </Form.Item>
          <Form.Item label="Email" name="email" rules={[{ required: true, message: 'Please input email!' }]}>
            <Input />
          </Form.Item>
          <Form.Item label="Address" name="address" rules={[{ required: true, message: 'Please input address!' }]}>
            <Input />
          </Form.Item>
          <Form.Item>
            <Button type="primary" htmlType="submit" style={{ backgroundColor: '#ff7700', borderColor: '#ff7700' }}>
              Save
            </Button>
          </Form.Item>
        </Form>
      </Modal> */}
    </div>
  );
}

export default AccountManager;
