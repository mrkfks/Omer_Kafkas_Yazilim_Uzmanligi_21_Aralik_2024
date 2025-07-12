import { Component, ElementRef, ViewChild } from '@angular/core';
import { Bar } from '../../components/bar/bar';
import { FormsModule } from '@angular/forms';
import { emailValid } from '../../utils/valids';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [Bar, FormsModule, RouterModule],
  templateUrl: './login.html',
  styleUrls: ['./login.css']
})
export class Login {
  @ViewChild("emailRef")
  emailRef: ElementRef | undefined;
  @ViewChild("passwordRef")
  passwordRef: ElementRef | undefined;

  placeHolderEmail = 'Lütfen Email Adresinizi Giriniz!'
  //user datas
  email = ''
  password = ''
  remember = false
  error = ''

  //fonksiyon

  userLogin() {
    if (!this.password) {
      this.error = 'password Empty!';
    } else {
      this.error = '';
      console.log("Data:", this.email, this.password);
      console.log("Data:", this.email, this.password, this.remember);
    }
  }
}
