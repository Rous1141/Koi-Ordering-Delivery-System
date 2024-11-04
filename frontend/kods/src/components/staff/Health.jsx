import React, { useState, useEffect } from "react";
import { Dialog } from "primereact/dialog";
import { DataTable } from "primereact/datatable";
import { Column } from "primereact/column";
import axios from "axios";
import { baseUrl, headers, getJwtToken } from "../api/Url";

export const Health = ({ orderId, visible, onHide }) => {
  const token = getJwtToken();
  const [health, setHealth] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const orderDetailResponse = await axios.get(`${baseUrl}/OrderDetails/Order/${orderId}`, {
          headers: {
            ...headers,
            'Authorization': `Bearer ${token}`,
          },
        });
        const orderDetailData = orderDetailResponse.data;
        
        const healthResponse = await axios.get(`${baseUrl}/HealthStatus/OrderDetails/${orderDetailData.id}`, {
          headers: {
            ...headers,
            'Authorization': `Bearer ${token}`,
          },
        });
        setHealth(healthResponse.data);
      } catch (error) {
        console.error("Error fetching health data:", error);
      }
    };

    if (visible && orderId) {
      fetchData();
    }
  }, [orderId, visible]);

  return (
    <Dialog
      header="Health Check"
      visible={visible}
      style={{ width: "60vw" }}
      onHide={onHide}
    >
      <div className="space-y-4 p-8">
        <DataTable
          value={health}
          showGridlines
          stripedRows
          tableStyle={{ minWidth: "50rem" }}
        >
          <Column field="orderId" header="Order ID" />
          <Column field="senderName" header="Sender" />
          <Column field="senderPhoneNumber" header="Sender Phone Number" />
          <Column field="senderAddress" header="Sender Address" />
          <Column field="totalCost" header="Total Costs" />
        </DataTable>
      </div>
    </Dialog>
  );
};
