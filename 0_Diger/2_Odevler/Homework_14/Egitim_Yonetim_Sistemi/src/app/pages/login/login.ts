import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { BackgroundItem } from '../../components/background-item/background-item';
import { ReactiveFormsModule, FormBuilder, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.html',
  styleUrl: './login.css',
  imports: [CommonModule, ReactiveFormsModule, BackgroundItem],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class Login {
  navigateToLogin() {
    throw new Error('Method not implemented.');
  }
  private fb = inject(FormBuilder);
  private auth = inject(AuthService); // service injection context içinde
  private router = inject(Router);

  readonly form = this.fb.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]],
  });


  submitting = false;

  submit() {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }
    this.submitting = true;
    const { email, password } = this.form.value;
    this.auth.login(email!, password!).subscribe((user) => {
      this.submitting = false;
      if (!user) {
        alert('Kullanıcı bulunamadı veya şifre hatalı');
        return;
      }
      console.log('Giriş başarılı', user);
  // başarılıysa ana sayfaya yönlendir
  this.router.navigate(['/']);
    });
  }

}
