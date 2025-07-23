import { ChangeDetectionStrategy, Component, ElementRef, ViewChild } from '@angular/core';
import { RouterModule } from '@angular/router';
import { emailValid, nameSurnameValid } from '../../utils/valids';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  imports: [RouterModule, FormsModule], // FormsModule burada olmalı
  templateUrl: './register.html',
  styleUrl: './register.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Register {
  email = ''
  name = ''
  password = ''
  passwordAgain = ''
  passlock = false
  passType = "password"
  error = ''
  success = ''


  constructor(private router:Router){
    console.log("Register Call")
  }
  @ViewChild('emailRef')
  emailRef: ElementRef | undefined;

  @ViewChild('nameRef')
  nameRef: ElementRef | undefined

  @ViewChild('passwordRef')
  passwordRef: ElementRef | undefined

  @ViewChild('passwordAgainRef')
  passwordAgainRef: ElementRef | undefined

  formReset(){
    this.name = ''
    this.email = ''
    this.password = ''
    this.passwordAgain = ''
  }

  userRegister(){
    this.error = ''
    this.success = ''
    const nameData = nameSurnameValid(this.name)
    const emailData = emailValid(this.email)

    if(nameData === null){
      this.error = 'Name / Surname not valid!'
      this.nameRef!.nativeElement.focus()
    }else if(emailData === null){
      this.error = 'Email not empty!'
      this.emailRef!.nativeElement.focus()
    }else if(this.password.length<8){
      this.error = 'Password count min 8 character!'
      this.passwordRef!.nativeElement.focus()
    }else if (this.password !== this.passwordAgain ){
      this.error = 'Password and Password Again not equals!'
      this.passwordAgainRef!.nativeElement.focus()
    }
  }

  passwordLockUnlock(){
    this.passlock = !this.passlock
    this.passType = !this.passType == true? 'text' : 'password'
  }


}
