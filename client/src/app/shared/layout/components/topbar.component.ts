import { Component, inject } from '@angular/core';

// PrimeNG
import { AvatarModule } from 'primeng/avatar';
import { CommonModule } from '@angular/common';
import { Menubar } from 'primeng/menubar';
import { ButtonModule } from 'primeng/button';
import { LayoutService } from '../services/layout.service';
import { Router, RouterModule } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-topbar',
  imports: [
    Menubar,
    AvatarModule,
    CommonModule,
    ButtonModule,
    RouterModule
  ],
  templateUrl: './topbar.component.html',
})
export class TopbarComponent {
  items: MenuItem[] | undefined;

  _layoutService = inject(LayoutService);

  constructor() {
    console.log('TopbarComponent Creado');
   }


  ngOnInit() {
    this.items = [
      {
        label: 'Inicio',
        icon: 'pi pi-home',
        routerLink: ['/'],
      },
      {
        label: 'Empleados',
        icon: 'pi pi-users',
        badge: '3',
        items: [
          {
            label: 'Usuarios',
            icon: 'pi pi-user',
            routerLink: ['/usuarios'],
          }
        ],
      },
    ];
  }

}
