import { Routes } from '@angular/router';
import { LayoutComponent } from './shared/layout/components/layout.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { UsuariosComponent } from './pages/usuarios/usuarios.component';

export const routes: Routes = [
  {
    path: '',
    component: LayoutComponent,
    children: [
      { path: '', component: DashboardComponent },
      { path: 'usuarios', component: UsuariosComponent },
    ]
  },
  { path: '**', redirectTo: '/notfound' }
];
