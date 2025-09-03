import { Component, inject, ChangeDetectionStrategy, OnInit, makeStateKey, TransferState } from '@angular/core';
import { Api } from '../../api';
import { CoursesItem } from '../../components/courses-item/courses-item';
import { BackgroundItem } from '../../components/background-item/background-item';
import { CommonModule } from '@angular/common';

interface Course {
  id: string;
  title: string;
  description?: string;
  price?: number;
  image?: string;
  instructorName?: string;
}

@Component({
  selector: 'app-courses',
  standalone: true,
  imports: [CommonModule, BackgroundItem, CoursesItem],
  templateUrl: './courses.html',
  styleUrl: './courses.css',
  changeDetection: ChangeDetectionStrategy.Default,
})
export class Courses implements OnInit {
  private readonly api = inject(Api);
  private readonly transferState = inject(TransferState);
  courses: Course[] = [];
  enrolling = new Set<string>();
  enrolled = new Set<string>();
  http: any;

  ngOnInit() {
    const COURSES_KEY = makeStateKey<Course[]>('courses');
    const cached = this.transferState.get(COURSES_KEY, null as any);
    if (cached) {
      this.courses = cached;
      this.transferState.remove(COURSES_KEY);
    } else {
      this.api.list<Course>('courses').subscribe((list) => {
        this.courses = [...list];
        this.transferState.set(COURSES_KEY, [...list]);
      });
    }
    // Kullanıcının kayıt olduğu kursları yükle
    const userRaw = typeof window !== 'undefined' ? localStorage.getItem('currentUser') : null;
    const user = userRaw ? JSON.parse(userRaw) : null;
    if (user) {
      this.api.list<any>('enrollments?userId=' + user.id).subscribe((enrolls) => {
        for (const e of enrolls) this.enrolled.add(e.courseId);
      });
    }
  }

  enroll = (courseId: string) => {
    this.enrolling.add(courseId);
    const userRaw = typeof window !== 'undefined' ? localStorage.getItem('currentUser') : null;
    const user = userRaw ? JSON.parse(userRaw) : null;
    if (!user) return;
    const payload = { userId: user.id, courseId };
    this.api.post('enrollments', payload).subscribe({
      next: () => {
        this.enrolling.delete(courseId);
        this.enrolled.add(courseId);
        alert('Kursa kayıt yapıldı');
      },
      error: () => {
        this.enrolling.delete(courseId);
        alert('Kayıt sırasında hata oluştu');
      },
    });
  };
}
