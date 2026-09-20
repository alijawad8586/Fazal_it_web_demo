import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { ServiceItem } from '../models/service.model';

@Injectable({ providedIn: 'root' })
export class ServicesApiService {
  private readonly baseUrl = `${environment.apiBaseUrl}/services`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<ServiceItem[]> {
    return this.http.get<ServiceItem[]>(this.baseUrl);
  }

  getBySlug(slug: string): Observable<ServiceItem> {
    return this.http.get<ServiceItem>(`${this.baseUrl}/${slug}`);
  }
}
