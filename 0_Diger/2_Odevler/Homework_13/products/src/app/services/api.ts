import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProducts, Product } from '../models/IProducts';
import { productsUrl } from '../utils/apiUrl';
import { Observable, map } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class Api {

constructor(private http:HttpClient) {}

  getProducts(limit: number, skip: number): Observable<IProducts> {
    return this.http.get<IProducts>(productsUrl.products, {
      params: {
        limit: limit.toString(),
        skip: skip.toString()
      }
    });
  }

  productsById(id: number): Observable<Product> {
    const url = `${productsUrl.products}/${id}`;
    return this.http.get<Product>(url);
  }
  
}
