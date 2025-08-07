import { ChangeDetectionStrategy, ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { IProducts, Product } from '../../models/IProducts';
import { ProductsItem } from '../../components/products-item/products-item';
import { Api } from '../../services/api';

@Component({
  selector: 'app-products',
  imports: [RouterModule, ProductsItem],
  templateUrl: './products.html',
  styleUrl: './products.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Products implements OnInit {
  productsArr: Product[] = [];

  constructor(private api:Api, private cdr: ChangeDetectorRef) {}
  ngOnInit(): void {
    this.api.getProducts(1, 10).subscribe({
      next: (value: IProducts): void => {
        this.productsArr = value.products
        this.cdr.detectChanges()
        console.log('Ürünler yüklendi:', this.productsArr);
      },
      error:(err) => {
        console.error('Ürünler yüklenmedi:', err)
      }
    })  
  
  }
}