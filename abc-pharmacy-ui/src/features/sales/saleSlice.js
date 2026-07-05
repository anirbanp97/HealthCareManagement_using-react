import { createSlice }
from "@reduxjs/toolkit";




const initialState =
{

    list:[]

};




const saleSlice =
createSlice({


    name:"sales",



    initialState,



    reducers:
    {


        setSales:
        (state,action)=>
        {


            state.list =
                action.payload;


        }


    }



});




export const {

    setSales

}
=
saleSlice.actions;




export default saleSlice.reducer;