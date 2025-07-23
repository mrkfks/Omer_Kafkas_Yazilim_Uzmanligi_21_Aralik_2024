import { ChangeDetectionStrategy, Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';
import { emailValid } from '../../utils/valids';

@Component({
  selector: 'app-login',
  imports: [RouterModule, FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Login {
email = ''

password = ''

remember = false

error = ''



@ViewChild("emailRef")
emailRef:ElementRef | undefined

@ViewChild("passwordRef")
passwordRef: ElementRef | undefined
  
userLogin(){
  this.error = ''
  const emailStatus = emailValid(this.email)
  if(!emailStatus) {
    this.error = 'Email Format Error'
    this.emailRef!.nativeElement.focus()
  }else if(this.password == ''){
    this.error = 'Password Empty!'
    this.passwordRef!.nativeElement.focus()
  }
}



}

