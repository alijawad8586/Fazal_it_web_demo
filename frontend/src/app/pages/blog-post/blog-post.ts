import { blogCover } from '../../core/utils/blog-cover';
import { Component, OnInit, signal } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { DatePipe } from '@angular/common';
import { BlogApiService } from '../../core/services/blog.service';
import { BlogPost } from '../../core/models/blog-post.model';

@Component({
  selector: 'app-blog-post',
  standalone: true,
  imports: [RouterLink, DatePipe],
  templateUrl: './blog-post.html',
  styleUrl: './blog-post.scss',
})
export class BlogPostComponent implements OnInit {
  protected readonly cover = blogCover;
  protected readonly post = signal<BlogPost | null>(null);
  protected readonly loading = signal(true);
  protected readonly error = signal(false);

  constructor(
    private route: ActivatedRoute,
    private blogApi: BlogApiService,
  ) {}

  ngOnInit(): void {
    const slug = this.route.snapshot.paramMap.get('slug') ?? '';
    this.blogApi.getBySlug(slug).subscribe({
      next: (post) => {
        this.post.set(post);
        this.loading.set(false);
      },
      error: () => {
        this.loading.set(false);
        this.error.set(true);
      },
    });
  }
}
