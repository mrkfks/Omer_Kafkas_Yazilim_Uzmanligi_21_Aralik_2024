import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { Login } from './pages/login/login';
import { Profile } from './pages/profile/profile';
import { Register } from './pages/register/register';
import { AboutUs } from './pages/about-us/about-us';
import { Courses } from './pages/courses/courses';

export const routes: Routes = [
    { path: '', component: Home },
    { path: 'login', component: Login },
    { path: 'profile', component: Profile },
    { path: 'register', component: Register },
    { path: 'about-us', component: AboutUs },
    { path: 'courses', component: Courses }
];
