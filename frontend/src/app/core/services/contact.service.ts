import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { ContactMessage } from '../models/contact-message.model';

@Injectable({ providedIn: 'root' })
export class ContactApiService {
  private readonly baseUrl = `${environment.apiBaseUrl}/contact`;

  constructor(private http: HttpClient) {}

  submit(message: ContactMessage): Observable<ContactMessage> {
    return this.http.post<ContactMessage>(this.baseUrl, message);
  }
}
