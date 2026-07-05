import {useState} from "react";
import {addMedicine} from "../../api/medicineApi";


function AddMedicine(){


const [data,setData]=useState({});



const change=e=>{

setData({

...data,

[e.target.name]:e.target.value

});

};




const submit=async e=>{

e.preventDefault();


await addMedicine(data);


alert("Medicine Added");

};





return(

<form onSubmit={submit}>


<input name="fullName"
placeholder="Medicine"
onChange={change}/>


<input name="brand"
placeholder="Brand"
onChange={change}/>


<input name="notes"
placeholder="Notes"
onChange={change}/>


<input name="expiryDate"
type="date"
onChange={change}/>


<input name="quantity"
placeholder="Quantity"
onChange={change}/>


<input name="price"
placeholder="Price"
onChange={change}/>



<button>
Save
</button>


</form>

);

}


export default AddMedicine;