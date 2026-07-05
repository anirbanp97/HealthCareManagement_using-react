import {useEffect} from "react";
import {getSales} from "../../api/saleApi";


function SaleList(){


useEffect(()=>{


getSales()
.then(x=>console.log(x.data));


},[]);



return(

<h2>Sales List</h2>

);


}

export default SaleList;