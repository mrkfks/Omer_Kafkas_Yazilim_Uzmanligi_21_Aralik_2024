import { Routes } from '@angular/router';
import { Login } from './pages/login/login';
import { register } from 'module';
import { Register } from './pages/register/register';

export const routes: Routes = [
    {path: "", component:Login},
    {path: "register", component:Register}
    
    
];
