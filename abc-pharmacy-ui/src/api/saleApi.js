import axiosClient from "./axiosClient";




// GET SALES


export const getSales =
    () => {


        return axiosClient.get(
            "/Sales"
        );


    };




// CREATE SALE


export const createSale =
    (data) => {


        return axiosClient.post(

            "/Sales",

            data

        );


    };