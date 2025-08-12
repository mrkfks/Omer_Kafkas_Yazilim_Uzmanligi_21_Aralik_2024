import { ChangeDetectionStrategy, ChangeDetectorRef, Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Api } from '../../services/api';
import { Product } from '../../models/IProducts';

@Component({
  selector: 'app-products-detail',
  standalone: true,
  imports: [],
  templateUrl: './products-detail.html',
  styleUrls: ['./products-detail.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProductsDetail {
  product: Product | null = null;
  globalprice = '';
  stars: any[] = [];
  bigimage = '';

  constructor(
    private route: ActivatedRoute,
    private api: Api,
    private router: Router,
    private cdr: ChangeDetectorRef
  ) {
    
    this.route.params.subscribe((params) => {
      const id = Number(params['id']);
      if (!Number.isNaN(id) && id > 0) {
        api.productsById(id).subscribe({
          next: (value) => {
            if (value) {
              this.product = value;
              this.globalprice = (
                value.price +
                (value.price * value.discountPercentage) / 100
              )
                .toFixed(2)
                .toString();

                this.countStars(value.rating);

                if (value.images && value.images.length > 0) {
                  this.bigimage = value.images[0];
            }

            console.log('value', value);
            this.cdr.detectChanges(); 
          }
        },
          error: (err) => {
            alert('Not found product: ' + id);
            this.router.navigate(['/products']);
            this.cdr.detectChanges();
          },
        });
      } else {
        alert('Not found product: ' + params[id]);
        this.router.navigate(['/products']);
        this.cdr.detectChanges();
      }
    });
  }

  countStars(raiting: number) {
    const arr: number[] = [];
    const tamPuan = Math.floor(raiting);
    const yarimPuan = Math.ceil(raiting - tamPuan);
    const bosPuan = 5 - (tamPuan + yarimPuan);

    for (let i = 0; i < tamPuan; i++) {
      arr.push(1);
    }
    if (yarimPuan > 0) {
      arr.push(0.5);
    }
    for (let i = 0; i < bosPuan; i++) {
      arr.push(0);
    }
    this.stars = arr;
  }

  changeImage(img : string){
    this.bigimage = img
  }
}
