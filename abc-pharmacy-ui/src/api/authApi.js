import axiosClient from "./axiosClient";

import { removeToken } from "../utils/tokenHelper";




// REGISTER

export const registerUser =
    (data) => {


        return axiosClient.post(

            "/Auth/register",

            data

        );


    };





// LOGIN

export const loginUser =
    (data) => {


        return axiosClient.post(

            "/Auth/login",

            data

        );


    };





// LOGOUT

export const logoutUser =
    () => {


        removeToken();


    };