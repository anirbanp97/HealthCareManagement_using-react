import { useState } from "react";

import { useDispatch } from "react-redux";

import { Link, useNavigate } from "react-router-dom";

import { loginUser } from "../../api/authApi";

import { loginSuccess } from "./authSlice";



function Login(){


const [email,setEmail]=useState("");

const [password,setPassword]=useState("");



const dispatch=useDispatch();

const navigate=useNavigate();




const submit=async(e)=>{


e.preventDefault();



const res=await loginUser({

email,

password

});



dispatch(

loginSuccess(res.data.token)

);



navigate("/medicines");


};





return(

<div className="form">


<h2>Login</h2>



<form onSubmit={submit}>


<input

placeholder="Email"

value={email}

onChange={e=>setEmail(e.target.value)}

/>



<input

type="password"

placeholder="Password"

value={password}

onChange={e=>setPassword(e.target.value)}

/>



<button>

Login

</button>


</form>



<p>

Don't have account?

<Link to="/register">

 Register

</Link>

</p>



</div>


);


}



export default Login;