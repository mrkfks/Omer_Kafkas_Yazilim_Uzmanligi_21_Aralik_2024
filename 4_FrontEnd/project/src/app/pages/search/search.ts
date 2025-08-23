import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-search',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './search.html',
  styleUrl: './search.css'
})
export class Search implements OnInit {

  constructor(private activeRouter: ActivatedRoute){}

  ngOnInit(): void {
    this.activeRouter.queryParams.forEach((params) => {
      const q = params['q']
      if (q) {
        console.log(q)
      }
    })
  }

}
