import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Bar } from '../../components/bar/bar';
import { emailValid, nameSurnameValid } from '../../utils/valids';
import { Router } from '@angular/router';
import { Api } from '../../services/api';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterModule, Bar],
  templateUrl: './register.html',
  styleUrl: './register.css'
})
export class Register {

  constructor(private router: Router, private api: Api){
    console.log("Register Call")
  }

  // register values
  name = ''
  email = ''
  password = ''
  passwordAgain = ''

  // additional properties
  passlock = false
  passType = "password"
  error = ''
  success = ''

  // register fnc
  userRegister() {
    this.error = ''
    this.success = ''
    const nameData = nameSurnameValid(this.name)
    if (nameData === '') {
      this.error = 'Name / Surname not valid!'
    } else if (!emailValid(this.email)) {
      this.error = 'Email not valid!'
    } else if (this.password === '') {
      this.error = 'Password empty!'
    } else if (this.password.length < 8) {
      this.error = 'Password count min 8'
    } else if (this.password !== this.passwordAgain) {
      this.error = 'Password and Password Again not equals!'
    } else {
      this.name = nameData
      this.api.userRegister(this.name, this.email, this.password).subscribe({
        next: (val) => {
          this.success = 'Register User Success'
          this.formReset()
          setTimeout(() => {
            this.router.navigate(['/'], {replaceUrl: true})
          }, 3000);
        },
        error: (err) => {
          this.error = 'E-Mail All ready in use!'
        }
      })
    }
  }

  // resetfnc
  formReset(){
    this.name = ''
    this.email = ''
    this.password = ''
    this.passwordAgain = ''
    this.error = ''
  }

  // password text lock and unlock
  passwordLockUnLock() {
    this.passlock = !this.passlock
    this.passType = this.passlock === true ? 'text' : 'password'
  }
}
