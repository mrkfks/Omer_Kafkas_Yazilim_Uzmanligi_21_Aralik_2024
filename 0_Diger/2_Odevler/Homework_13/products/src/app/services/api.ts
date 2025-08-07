import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProducts } from '../models/IProducts';
import { productsUrl } from '../utils/apiUrl';


@Injectable({
  providedIn: 'root'
})
export class Api {

constructor(private http:HttpClient) {}

  getProducts(limit: number, skip: number) {
    const sendObj = {
      limit:limit,
      skip:skip
    }
   return this.http.get<IProducts>(productsUrl.products, {params:sendObj})
  }
  
}
