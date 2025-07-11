import { Component } from '@angular/core';
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
    }else if(!emailValid(this.email)){
      this.error = 'Email not valid'
    }else if(this.password === ''){
      this.error = 'Password empty!'
    }else if (this.password !== this.passwordAgain){
      this.error ='Pasword and Password Again not equals!'
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
