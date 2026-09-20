import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home';
import { ServicesComponent } from './pages/services/services';
import { AboutComponent } from './pages/about/about';
import { BlogComponent } from './pages/blog/blog';
import { BlogPostComponent } from './pages/blog-post/blog-post';
import { ContactComponent } from './pages/contact/contact';

export const routes: Routes = [
  { path: '', component: HomeComponent, title: 'Fazal Tech Solutions' },
  { path: 'services', component: ServicesComponent, title: 'Services | Fazal Tech Solutions' },
  { path: 'about', component: AboutComponent, title: 'About | Fazal Tech Solutions' },
  { path: 'blog', component: BlogComponent, title: 'Blog | Fazal Tech Solutions' },
  { path: 'blog/:slug', component: BlogPostComponent, title: 'Blog | Fazal Tech Solutions' },
  { path: 'contact', component: ContactComponent, title: 'Contact | Fazal Tech Solutions' },
  { path: '**', redirectTo: '' },
];
