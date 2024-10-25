import { createBrowserRouter } from "react-router-dom";
import LoginPage from "./components/common/LoginPage";
import SignupPage from "./components/common/SignupPage";
// import ProfilePage from './components/customer/ProfilePage';
import OrderHistoryPage from "./components/customer/OrderHistoryPage";

import Homepage from "./components/common/Homepages";
import Feedback from "./components/customer/Feedback";
import FeedbackList from "./components/customer/FeedbackList";
// import OrderForm from './components/customer/OrderForm';
import OrderStatusTracking from "./components/customer/OrderStatusTracking";
import TrackingStaff from "./components/admin/TrackingStaff";

import ViewOrderHistory from "./components/customer/ViewOrderHistory";
import ViewOrderDetail from "./components/customer/ViewOrderDetail";
import OrdersDashBoard from "./components/admin/OrdersDashBoard";
import PlaceOrder from "./components/customer/PlaceOrder";
// import ProfilePage from "./components/customer/ProfilePage";
import PrivateRoute from "./components/PrivateRoute";
import UserProfilePage from "./components/customer/profile";
import AddFishForm from "./components/customer/profile/AddFishForm"; // Import AddFishForm
import { StaffDashBoard } from "./components/staff/StaffDashBoard";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <Homepage />,
  },
  {
    path: "/login",
    element: <LoginPage />,
  },
  {
    path: "/signup",
    element: <SignupPage />,
  },
  {
    path: "/profile",
    element: <UserProfilePage />,
    children: [
      {
        path: "customer",
        element: <UserProfilePage />,
      },
      {
        path: "addfish", // Thêm đường dẫn cho Add Fish
        element: <AddFishForm />, // Hiển thị AddFishForm
      },
    ],
  },
  {
    path: "/orderhistory",
    element: <OrderHistoryPage />,
  },
  {
    path: "/feedback",
    element: <Feedback />,
  },
  {
    path: "/orderform",
    element: <PlaceOrder />,
  },
  {
    path: "/ordersDashBoard",
    element: <OrdersDashBoard />,
  },
  {
    path: "/feedbacklist",
    element: <FeedbackList />,
  },
  {
    path: "/ordertracking",
    element: (
      <PrivateRoute>
        <OrderStatusTracking />
      </PrivateRoute>
    ), // Wrapped with PrivateRoute
  },
  {
    path: "/trackingstaff",
    element: <TrackingStaff />,
  },
  {
    path: "/orders/:id",
    element: <ViewOrderDetail />,
  },
  {
    path: "/orders",
    element: <ViewOrderHistory />,
  },
  {
    path: "/staffDashBoard",
    element: <StaffDashBoard />,
  },
]);
