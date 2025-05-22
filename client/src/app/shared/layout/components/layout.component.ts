import { Component } from '@angular/core';

import { RouterModule } from '@angular/router';
import { TopbarComponent } from './topbar.component';

@Component({
  selector: 'app-layout',
  imports: [
    RouterModule,
    TopbarComponent
  ],
  templateUrl: './layout.component.html',
})
export class LayoutComponent {
  constructor() {
    console.log('LayoutComponent creado');
  }
}
