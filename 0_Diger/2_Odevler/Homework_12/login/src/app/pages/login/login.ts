import { ChangeDetectorRef, Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Router } from 'express';
import { Api } from '../../services/api';

@Component({
  selector: 'app-login',
  imports: [RouterModule, FormsModule],
  templateUrl: './login.html',
  styleUrls: ['./login.css']
})
export class Login {

  email = ''
  password = ''
  remember = ''
  error = ''

  @ViewChild("emailRef")
  emailRef:ElementRef | undefined

  @ViewChild("passwordRef")
  passwordRef: ElementRef | undefined
  api: any;

  constructor(
    private router:Router, 
    private Api: Api,
    private cdr: ChangeDetectorRef)
    {}

  userLogin(){
    this.api.userLogin(this.email,this.password).subscribe({
      next: (val : any) => {
        console.log("Giriş Başarılı! Kullanıcı Bilgileri:", val)
      }
    })


  }

}
