import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './footer.html',
  styleUrl: './footer.scss',
})
export class FooterComponent {
  protected readonly year = new Date().getFullYear();

  protected readonly services = [
    { label: 'Website Development', path: '/services' },
    { label: 'Website Design', path: '/services' },
    { label: 'Website Redesign', path: '/services' },
    { label: 'Website Maintenance', path: '/services' },
    { label: 'E-commerce Development', path: '/services' },
    { label: 'AI & Automation Solutions', path: '/services' },
  ];

  protected readonly company = [
    { label: 'About Us', path: '/about' },
    { label: 'Services', path: '/services' },
    { label: 'Blog', path: '/blog' },
    { label: 'Contact', path: '/contact' },
  ];
}
