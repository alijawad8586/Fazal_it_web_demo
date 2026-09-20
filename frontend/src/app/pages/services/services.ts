import { Component, OnInit, signal } from '@angular/core';
import { RouterLink } from '@angular/router';
import { ServicesApiService } from '../../core/services/services.service';
import { ServiceItem } from '../../core/models/service.model';
import { ServiceIconComponent } from '../../shared/service-icon/service-icon';

@Component({
  selector: 'app-services',
  standalone: true,
  imports: [RouterLink, ServiceIconComponent],
  templateUrl: './services.html',
  styleUrl: './services.scss',
})
export class ServicesComponent implements OnInit {
  protected readonly services = signal<ServiceItem[]>([]);
  protected readonly loading = signal(true);
  protected readonly error = signal(false);

  constructor(private servicesApi: ServicesApiService) {}

  ngOnInit(): void {
    this.servicesApi.getAll().subscribe({
      next: (services) => {
        this.services.set(services);
        this.loading.set(false);
      },
      error: () => {
        this.loading.set(false);
        this.error.set(true);
      },
    });
  }
}
