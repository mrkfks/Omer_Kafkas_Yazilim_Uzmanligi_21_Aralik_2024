import { ChangeDetectorRef, Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Api } from '../../services/api';
import { Router } from 'express';
import { Product } from '../../models/IProducts';

@Component({
  selector: 'app-products-detail',
  imports: [],
  templateUrl: './products-detail.html',
  styleUrl: './products-detail.css'
})
export class ProductsDetail {

  product: Product | null = null
  

  constructor(private route: ActivatedRoute, private api: Api, private router: Router, private cdr: ChangeDetectorRef){
    
  }

}
