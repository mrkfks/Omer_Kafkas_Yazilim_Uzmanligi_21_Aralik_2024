import { Component, NgModule, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';



@Component({
  selector: 'app-root,app-navbar',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})


export class App {
  protected readonly title = signal('Homework_12');
}

