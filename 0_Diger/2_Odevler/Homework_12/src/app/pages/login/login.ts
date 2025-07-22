import { Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Router } from 'express';

@Component({
  selector: 'app-login',
  imports: [RouterModule, FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {

@ViewChild("emailRef")
emailRef:ElementRef | undefined

@ViewChild("passwordRef")
passwordRef: ElementRef | undefined
  

email = ''

password = ''

remember = false


}

