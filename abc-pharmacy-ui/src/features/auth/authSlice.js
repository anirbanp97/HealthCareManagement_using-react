import { createSlice } 
from "@reduxjs/toolkit";


import { 
    saveToken,
    removeToken,
    getToken
}
from "../../utils/tokenHelper";




const initialState =
{

    token:
        getToken(),

    isLoggedIn:
        !!getToken()

};





const authSlice =
createSlice({


    name:"auth",



    initialState,



    reducers:
    {



        loginSuccess:
        (state,action)=>
        {


            state.token =
                action.payload;



            state.isLoggedIn =
                true;



            saveToken(
                action.payload
            );


        },





        logout:
        (state)=>
        {


            state.token =
                null;



            state.isLoggedIn =
                false;



            removeToken();


        }


    }


});




export const {

    loginSuccess,

    logout

}
=
authSlice.actions;




export default authSlice.reducer;