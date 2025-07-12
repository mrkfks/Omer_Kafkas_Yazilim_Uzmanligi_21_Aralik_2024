import { Component, ElementRef, ViewChild } from '@angular/core';
import { Bar } from '../../components/bar/bar';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { emailValid, nameSurnameValid } from '../../utils/valids';

@Component({
  selector: 'app-register',
  imports: [Bar, FormsModule,RouterModule],
  templateUrl: './register.html',
  styleUrl: './register.css'
})
export class Register {

  @ViewChild("nameRef")
  nameRef : ElementRef | undefined

  @ViewChild("nameRef")
  emailRef : ElementRef | undefined

  @ViewChild("nameRef")
  passwordRef : ElementRef | undefined

  @ViewChild("nameRef")
  passwordAgainRef : ElementRef | undefined

  passlock: boolean = false;
  passType = "password"
  error = '';

  //register values
  email = ''
  name = ''
  password = ''
  passwordAgain = ''


  //register fnc
  userRegister(){
    this.error = ''
    const nameData = nameSurnameValid(this.name)
    if(nameData === '') {
      this.error = 'Name / Surname not valid'
      this.nameRef!.nativeElement.focus()
    }else if(!emailValid(this.email)){
      this.error = 'Email not valid'
      this.emailRef!.nativeElement.focus()
    }else if(this.password === ''){
      this.error = 'Password empty!'
      this.passwordRef!.nativeElement.focus()
    }else if (this.password !== this.passwordAgain){
      this.error ='Pasword and Password Again not equals!'
      this.passwordAgainRef!.nativeElement.focus()
    }else{
      console.log("Form Send")
      console.log (this.name, this.email, this.password)
    }
  }

  formReset(){
    this.name = ''
    this.email = ''
    this.password = ''
    this.passwordAgain =''
    this.error = ''
  }

  //password text lock and unlock

  passwordLockUnLock(){
    this.passlock = !this.passlock
    this.passType = this.passlock == true ? 'text' : 'password'
  }
}
