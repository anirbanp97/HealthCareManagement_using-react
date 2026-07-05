import {Routes,Route,Navigate} from "react-router-dom";


import Login from "../features/auth/Login";

import Register from "../features/auth/Register";


import MedicineList from "../features/medicines/MedicineList";

import AddMedicine from "../features/medicines/AddMedicine";


import SaleList from "../features/sales/SaleList";

import AddSale from "../features/sales/AddSale";



function AppRoutes(){


return(

<Routes>


<Route 
path="/" 
element={<Navigate to="/login"/>}
/>


<Route 
path="/login" 
element={<Login/>}
/>


<Route 
path="/register" 
element={<Register/>}
/>


<Route 
path="/medicines" 
element={<MedicineList/>}
/>


<Route 
path="/add-medicine" 
element={<AddMedicine/>}
/>


<Route 
path="/sales" 
element={<SaleList/>}
/>


<Route 
path="/add-sale" 
element={<AddSale/>}
/>


</Routes>

);

}


export default AppRoutes;