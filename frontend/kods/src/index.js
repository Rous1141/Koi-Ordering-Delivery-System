// import React, { StrictMode } from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import SnackbarProviders from "./provider/notification";
import { ToastContainer } from "react-toastify";
// import { GoogleOAuthProvider } from "@react-oauth/google";
const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(

  <SnackbarProviders>
    <App />
    <ToastContainer />
  </SnackbarProviders>

);
reportWebVitals();
