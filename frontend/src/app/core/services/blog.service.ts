import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { BlogPost } from '../models/blog-post.model';

@Injectable({ providedIn: 'root' })
export class BlogApiService {
  private readonly baseUrl = `${environment.apiBaseUrl}/blog`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<BlogPost[]> {
    return this.http.get<BlogPost[]>(this.baseUrl);
  }

  getBySlug(slug: string): Observable<BlogPost> {
    return this.http.get<BlogPost>(`${this.baseUrl}/${slug}`);
  }
}
