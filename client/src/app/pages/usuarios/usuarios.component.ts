import { Component, inject } from '@angular/core';
import { UsuarioService } from '../../services/usuario.service';
import { Usuario } from '../../models/usuario';

// PrimeNG
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { CardModule } from 'primeng/card';
import { ToolbarModule } from 'primeng/toolbar';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { Tag } from 'primeng/tag';

// Proyecto
import { UsuarioDialogComponent } from './components/usuario-dialog/usuario-dialog.component';
import { CrearUsuarioRequest } from '../../models/crear-usuario-request';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  imports: [
    TableModule,
    ButtonModule,
    InputTextModule,
    CardModule,
    ToolbarModule,
    IconFieldModule,
    InputIconModule,
    Tag,
    UsuarioDialogComponent,
  ],
})
export class UsuariosComponent {
  _usuarioService = inject(UsuarioService);

  usuarios: Usuario[] = [];

  mostrarDialog = false;

  ngOnInit() {
    this._usuarioService.obtenerUsuarios().subscribe((data) => {
      this.usuarios = data;
    });
  }

  getSeverity(status: boolean) {
    if (status)
      return 'success';

    return 'danger';
  }

  editarUsuario(usuario: Usuario) { }

  eliminarUsuario(usuario: Usuario) { }

  abrirDialog() {
    this.mostrarDialog = true;
  }

  onGuardarUsuario(nuevoUsuario: CrearUsuarioRequest) {
    console.log('Nuevo usuario:', nuevoUsuario);
    this._usuarioService.guardarUsuario(nuevoUsuario).subscribe((id) => {
      console.log('Usuario guardado con ID:', id);
    }, error => {
      console.error('Error al guardar el usuario:', error.error);
    });
  }
}
