import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './about.html',
  styleUrl: './about.scss',
})
export class AboutComponent {
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
      text: 'Our relationship doesn’t have to end when your website goes live. We can help with maintenance, updates, improvements, and technical support.',
    },
    {
      title: 'Quality & Reliability',
      text: 'We pay attention to performance, usability, responsiveness, and the overall quality of every project.',
    },
  ];

  protected readonly services = [
    'Website Development — Fast, responsive, and scalable websites.',
    'Website Design — Modern and user-friendly designs that represent your brand.',
    'Website Redesign — Transforming outdated websites into modern digital experiences.',
    'Website Maintenance — Keeping websites secure, updated, and running smoothly.',
    'Bug Fixing & Technical Support — Finding and resolving website problems.',
    'E-commerce Development — Helping businesses sell products and services online.',
    'AI & Automation Solutions — Using modern AI technologies to automate tasks and improve business workflows.',
  ];
}
