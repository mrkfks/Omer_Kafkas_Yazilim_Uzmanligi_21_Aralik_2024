import { inject, Injectable, signal } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';

export interface UserDto {
  id?: string | number;
  name: string;
  surname: string;
  email: string;
  password: string;
  profilePhoto?: string;
  role?: 'student' | 'instructor' | 'admin';
}

@Injectable({ providedIn: 'root' })

export class AuthService {
  private http = inject(HttpClient);
  private readonly api = 'http://localhost:3000';

  // localStorage destekli auth state
  readonly currentUser = signal<UserDto | null>(this.loadUserFromStorage());

  private loadUserFromStorage(): UserDto | null {
    if (typeof window === 'undefined') return null;
    const raw = localStorage.getItem('currentUser');
    if (!raw) return null;
    try {
      return JSON.parse(raw);
    } catch {
      return null;
    }
  }


  register(user: Omit<UserDto, 'id'>): Observable<UserDto> {
    return this.http.post<UserDto>(`${this.api}/users`, user);
  }


  login(email: string, password: string): Observable<UserDto | null> {
    return this.http
      .get<UserDto[]>(`${this.api}/users`, { params: { email } })
      .pipe(
        map(list => {
          const found = list.find(u => u.password === password);
          this.currentUser.set(found ?? null);
          if (found) {
            localStorage.setItem('currentUser', JSON.stringify(found));
          } else {
            localStorage.removeItem('currentUser');
          }
          return found ?? null;
        })
      );
  }

  logout() {
    this.currentUser.set(null);
    localStorage.removeItem('currentUser');
  }
}