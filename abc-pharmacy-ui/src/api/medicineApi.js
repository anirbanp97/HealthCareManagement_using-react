import axiosClient from "./axiosClient";




// GET ALL MEDICINES

export const getMedicines =
    () => {


        return axiosClient.get(
            "/Medicines"
        );


    };




// ADD MEDICINE

export const addMedicine =
    (data) => {


        return axiosClient.post(

            "/Medicines",

            data

        );


    };