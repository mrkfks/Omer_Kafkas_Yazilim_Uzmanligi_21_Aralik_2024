import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { Login } from './pages/login/login';
import { Profile } from './pages/profile/profile';
import { Register } from './pages/register/register';

export const routes: Routes = [
    {path: "", component: Home},
    {path: "login", component: Login},
    {path: "profile", component: Profile},
    {path: "register", component: Register}
];
