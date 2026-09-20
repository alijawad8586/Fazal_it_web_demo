import { Component, inject, signal } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { ContactApiService } from '../../core/services/contact.service';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './contact.html',
  styleUrl: './contact.scss',
})
export class ContactComponent {
  private readonly fb = inject(FormBuilder);
  private readonly contactApi = inject(ContactApiService);

  protected readonly submitting = signal(false);
  protected readonly sent = signal(false);
  protected readonly failed = signal(false);

  protected readonly form = this.fb.nonNullable.group({
    name: ['', [Validators.required, Validators.maxLength(120)]],
    email: ['', [Validators.required, Validators.email, Validators.maxLength(200)]],
    subject: ['', [Validators.maxLength(150)]],
    message: ['', [Validators.required, Validators.maxLength(4000)]],
  });

  protected invalid(control: 'name' | 'email' | 'message'): boolean {
    const c = this.form.controls[control];
    return c.invalid && (c.touched || c.dirty);
  }

  protected submit(): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }
    this.submitting.set(true);
    this.failed.set(false);
    const { subject, ...rest } = this.form.getRawValue();
    this.contactApi.submit({ ...rest, ...(subject ? { subject } : {}) }).subscribe({
      next: () => {
        this.submitting.set(false);
        this.sent.set(true);
        this.form.reset();
      },
      error: () => {
        this.submitting.set(false);
        this.failed.set(true);
      },
    });
  }
}
