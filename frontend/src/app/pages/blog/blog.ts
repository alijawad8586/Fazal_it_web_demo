import { blogCover } from '../../core/utils/blog-cover';
import { Component, OnInit, signal } from '@angular/core';
import { RouterLink } from '@angular/router';
import { BlogApiService } from '../../core/services/blog.service';
import { BlogPost } from '../../core/models/blog-post.model';

@Component({
  selector: 'app-blog',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './blog.html',
  styleUrl: './blog.scss',
})
export class BlogComponent implements OnInit {
  protected readonly cover = blogCover;
  protected readonly posts = signal<BlogPost[]>([]);
  protected readonly loading = signal(true);
  protected readonly error = signal(false);

  constructor(private blogApi: BlogApiService) {}

  ngOnInit(): void {
    this.blogApi.getAll().subscribe({
      next: (posts) => {
        this.posts.set(posts);
        this.loading.set(false);
      },
      error: () => {
        this.loading.set(false);
        this.error.set(true);
      },
    });
  }
}
