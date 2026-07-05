import {useEffect} from "react";
import {useDispatch,useSelector} from "react-redux";
import {getMedicines} from "../../api/medicineApi";
import {setMedicines} from "./medicineSlice";


function MedicineList(){


const dispatch=useDispatch();


const medicines=
useSelector(x=>x.medicines.list);



useEffect(()=>{


load();


},[]);



const load=async()=>{


const res=
await getMedicines();


dispatch(
setMedicines(res.data)
);


};




return(

<div>

<h2>Medicines</h2>


<table>

<tbody>


{medicines.map(x=>

<tr key={x.id}>

<td>{x.fullName}</td>

<td>{x.brand}</td>

<td>{x.quantity}</td>

<td>{x.price}</td>

</tr>


)}


</tbody>

</table>

</div>


);

}


export default MedicineList;