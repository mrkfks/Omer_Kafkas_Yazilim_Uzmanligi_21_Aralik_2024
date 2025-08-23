import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Bar } from '../../components/bar/bar';
import { emailValid } from '../../utils/valids';
import { Router } from '@angular/router';
import { Api } from '../../services/api';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule, Bar],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {

  // user models
  email = ''
  password = ''
  remember = false
  error = ''

  constructor(private router: Router, private api: Api) {}

  // fonksion
  userLogin() {
    this.error = ''
    const emailStatus = emailValid(this.email)
    if (!emailStatus) {
      this.error = 'Email format error'
    } else if (this.password === '') {
      this.error = 'Password Empty!'
    } else {
      this.api.userLogin(this.email, this.password).subscribe({
        next: (val) => {
          localStorage.setItem("token", val.data.access_token)
          window.location.replace('/products')
        },
        error: (err) => {
          this.error = 'E-Mail or Password Fail'
        }
      })
    }
  }

  validEmail() {
    console.log("Email Call", this.email)
  }
}
