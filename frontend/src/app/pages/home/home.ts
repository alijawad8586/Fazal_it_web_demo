import { blogCover } from '../../core/utils/blog-cover';
import { Component, OnInit, signal } from '@angular/core';
import { RouterLink } from '@angular/router';
import { ServicesApiService } from '../../core/services/services.service';
import { BlogApiService } from '../../core/services/blog.service';
import { ServiceItem } from '../../core/models/service.model';
import { BlogPost } from '../../core/models/blog-post.model';
import { ServiceIconComponent } from '../../shared/service-icon/service-icon';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RouterLink, ServiceIconComponent],
  templateUrl: './home.html',
  styleUrl: './home.scss',
})
export class HomeComponent implements OnInit {
  protected readonly cover = blogCover;
  protected readonly services = signal<ServiceItem[]>([]);
  protected readonly latestPosts = signal<BlogPost[]>([]);

  protected readonly approachSteps = [
    'Look professional',
    'Be easy to use',
    'Load quickly',
    'Work on every device',
    'Support your business goals',
  ];

  protected readonly whyChooseUs = [
    {
      title: 'Business-Focused Solutions',
      text: "We don't believe in one-size-fits-all websites. We create solutions based on your business, audience, and goals.",
    },
    {
      title: 'Modern Technology',
      text: 'We use modern development tools and technologies to build reliable and scalable digital products.',
    },
    {
      title: 'Simple & Clear Communication',
      text: 'We keep the process understandable and communicate clearly throughout the project.',
    },
    {
      title: 'Long-Term Support',
      text: 'Our relationship doesn’t have to end when your website goes live. We help with maintenance, updates, and technical support.',
    },
    {
      title: 'Quality & Reliability',
      text: 'We pay attention to performance, usability, responsiveness, and the overall quality of every project.',
    },
  ];

  constructor(
    private servicesApi: ServicesApiService,
    private blogApi: BlogApiService,
  ) {}

  ngOnInit(): void {
    this.servicesApi.getAll().subscribe({
      next: (services) => this.services.set(services.slice(0, 6)),
      error: () => this.services.set([]),
    });

    this.blogApi.getAll().subscribe({
      next: (posts) => this.latestPosts.set(posts.slice(0, 3)),
      error: () => this.latestPosts.set([]),
    });
  }
}
