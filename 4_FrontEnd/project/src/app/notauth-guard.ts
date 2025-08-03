import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router';
import { Api } from './services/api';
import { lastValueFrom } from 'rxjs';

export const notauthGuard: CanActivateFn = async (route, state) => {
  const api = inject(Api);
  const stToken = localStorage.getItem('token')
  if (stToken) {
    try {
      const res = await lastValueFrom( api.userProfileSync() )
      if(res) {
        window.location.replace('/products')
        return false
      }
    } catch (error) {
      localStorage.removeItem('token')
      window.location.reload()
      return true
    }
  }
  return true
};
