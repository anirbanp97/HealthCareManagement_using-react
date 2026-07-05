import { createSlice }
from "@reduxjs/toolkit";



const initialState =
{

    list:[]

};





const medicineSlice =
createSlice({

    name:"medicines",


    initialState,


    reducers:
    {


        setMedicines:
        (state,action)=>
        {

            state.list =
                action.payload;

        }


    }


});




export const {

    setMedicines

}
=
medicineSlice.actions;



export default medicineSlice.reducer;