import { Component, input } from '@angular/core';

@Component({
  selector: 'app-service-icon',
  standalone: true,
  templateUrl: './service-icon.html',
  styles: `
    :host {
      display: inline-flex;
    }

    svg {
      width: 24px;
      height: 24px;
    }
  `,
})
export class ServiceIconComponent {
  icon = input<string>('code');
}
