import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProducts } from '../models/IProducts';
import { productsUrl } from '../utils/apiUrl';


@Injectable({
  providedIn: 'root'
})
export class Api {

constructor(private http:HttpClient) {}

  getProducts(title: number, price: number) {
    const sendObj = {
      title:title,
      price:price
    }
   return this.http.get<IProducts>(productsUrl.products, {params:sendObj})
  }
  
}
