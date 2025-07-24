import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Api } from '../../services/api';

@Component({
  selector: 'app-products',
  imports: [RouterModule],
  templateUrl: './products.html',
  styleUrl: './products.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Products implements OnInit {

  productsArr: string[] = [];

  constructor(private api: Api, private cdr: ChangeDetectorRef) {
    const stToken = localStorage.getItem('token');
    if (!stToken) {
      window.location.replace('/');
    }
  }

  ngOnInit(): void {
    this.api.allProducts(1, 10).subscribe({
      next: (value: any) => {
        this.productsArr = value.tags;
        this.cdr.detectChanges();
      },
      error: (_error: any) => {
        // Hata yönetimi
      }
    });
  }

}
