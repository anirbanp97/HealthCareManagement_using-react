import { useState } from "react";

import { Link, useNavigate } from "react-router-dom";

import { registerUser } from "../../api/authApi";



function Register(){


    const [form,setForm] = useState({

        fullName:"",
        email:"",
        password:""

    });



    const navigate = useNavigate();




    const change = (e) =>{


        setForm({

            ...form,

            [e.target.name]: e.target.value

        });


    };





    const submit = async(e)=>{


        e.preventDefault();



        try{


            await registerUser(form);



            alert("Registration Successful");



            navigate("/login");


        }
        catch(error){


            alert(
                "Registration Failed"
            );


            console.log(error);


        }


    };







    return(

        <div className="form">


            <h2>Register</h2>



            <form onSubmit={submit}>


                <input

                    name="fullName"

                    placeholder="Full Name"

                    value={form.fullName}

                    onChange={change}

                />



                <input

                    name="email"

                    placeholder="Email"

                    value={form.email}

                    onChange={change}

                />



                <input

                    name="password"

                    type="password"

                    placeholder="Password"

                    value={form.password}

                    onChange={change}

                />



                <button>

                    Register

                </button>



            </form>





            <p>

                Already have account?


                <Link to="/login">

                    Login

                </Link>


            </p>



        </div>

    );


}



export default Register;