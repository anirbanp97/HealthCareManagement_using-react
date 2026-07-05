import {useState} from "react";
import {createSale} from "../../api/saleApi";


function AddSale(){


const [data,setData]=useState({});



const change=e=>{


setData({

...data,

[e.target.name]:e.target.value

});

};



const submit=e=>{

e.preventDefault();


createSale(data);


alert("Sale Done");


};



return(

<form onSubmit={submit}>


<input
name="medicineId"
placeholder="Medicine Id"
onChange={change}
/>


<input
name="quantitySold"
placeholder="Quantity"
onChange={change}
/>


<button>
Sell
</button>


</form>

);

}


export default AddSale;