import { ChangeDetectionStrategy, ChangeDetectorRef, Component, ElementRef, ViewChild } from '@angular/core';
import { Bar } from '../../components/bar/bar';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { emailValid, nameSurnameValid } from '../../utils/valids';
import { Api } from '../../services/api';

@Component({
  selector: 'app-register',
  imports: [Bar, FormsModule, RouterModule],
  templateUrl: './register.html',
  styleUrl: './register.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Register {

  constructor(private router: Router, private api: Api, private cdr: ChangeDetectorRef){
    console.log("Register Call")
  }

  @ViewChild("nameRef")
  nameRef:ElementRef | undefined
  @ViewChild("emailRef")
  emailRef:ElementRef | undefined
  @ViewChild("passwordRef")
  passwordRef:ElementRef | undefined
  @ViewChild("passwordAgainRef")
  passwordAgainRef:ElementRef | undefined

  passlock = false
  passType = "password"
  error = ''
  success = ''

  // register values
  name = ''
  email = ''
  password = ''
  passwordAgain = ''

  // register fnc
  userRegister() {
    this.error = ''
    this.success = ''

    const nameData = nameSurnameValid(this.name)
    if (nameData === '') {
      this.error = 'Name / Surname not valid!'
      this.nameRef!.nativeElement.focus()
    }else if (!emailValid(this.email)) {
      this.error = 'Email not vali!'
      this.emailRef!.nativeElement.focus()
    }else if (this.password === '') {
      this.error = 'Password empty!'
      this.passwordRef!.nativeElement.focus()
    }else if (this.password !== this.passwordAgain) {
      this.error = 'Password and Password Again not equals!'
      this.passwordAgainRef!.nativeElement.focus()
    }else {
      this.name = nameData
      // 1. javascript
      //window.location.href = '/'
      // 2. bir önceki ekrana dönüşü engelle
      //window.location.replace('/')
      // 3. Router ile geçiş - tavsiye
      //this.router.navigate(['/'], {replaceUrl: true, queryParams: {id: 10}})
      this.api.userRegister(this.name, this.email, this.password).subscribe({
        next:(val) => {
          this.success = 'Register User Success'
          this.formReset()
          this.cdr.detectChanges()
          setTimeout(() => {
            this.error = 'E-Mail All ready in use!'
            this.cdr.detectChanges()
          }, 2000)
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
