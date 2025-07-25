import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IUsers } from '../models/IUser';
import { productUrl, userUrl } from '../utils/apiUrl';
import { IProducts } from '../models/IProducts';

@Injectable({
  providedIn: 'root'
})
export class Api {
  
  constructor(private http:HttpClient){}

  userLogin(email:string, password:string){
    const sendObj ={
      email: email,
      password: password
    }
    return this.http.post<IUsers>(userUrl.login, sendObj)
  }


  allProducts(page: number, per_page: number) {
    const sendObj = {
      page: page,
      per_page : per_page
    }
    return this.http.get<IProducts>(productUrl.products, {params: sendObj})
  }


}
