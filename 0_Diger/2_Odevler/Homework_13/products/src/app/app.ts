import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Bar } from "./components/bar/bar";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Bar],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('products');
}
