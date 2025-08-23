import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Api } from '../../services/api';
import { Comment } from '../../models/IComments';
;

@Component({
  selector: 'app-comments',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './comments.html',
  styleUrl: './comments.css'
})
export class Comments {

  commentArr:Comment[] = []
  loading = true

  constructor( private api: Api ){
  }


  ngOnInit(): void {
    this.api.productComment(1,10).subscribe({
      next: (value) => {
        this.commentArr = value.data
        this.loading = false
      },
      error: (error) => {

      }
    })
  }

  

}
