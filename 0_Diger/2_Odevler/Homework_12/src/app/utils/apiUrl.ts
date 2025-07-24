import { register } from "module"

const baseURL = "https://dummyjson.com"

export const userUrl = {
    login: `${baseURL}/users`,
    register: `${baseURL}/users/add`
}

export const productUrl = {
    products: `${baseURL}/products`
}