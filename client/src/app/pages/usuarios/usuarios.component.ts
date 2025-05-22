import { Component, inject } from '@angular/core';
import { UsuarioService } from './services/usuario.service';
import { Usuario } from './interfaces/usuario';

// PrimeNG
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { CardModule } from 'primeng/card';
import { ToolbarModule } from 'primeng/toolbar';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { Tag } from 'primeng/tag';
import { UsuarioDialogComponent } from './components/usuario-dialog/usuario-dialog.component';

@Component({
  selector: 'app-usuarios',
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
  templateUrl: './usuarios.component.html',
})
export class UsuariosComponent {
  _usuarioService = inject(UsuarioService);

  usuarios: Usuario[] = [];

  mostrarDialog = false;

  ngOnInit() {
    this._usuarioService.obtenerUsuarios().subscribe((data) => {
      this.usuarios = data;
      console.log(data);
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

  onGuardarUsuario(usuario: any) {
    // this._usuarioService.crearUsuario(usuario).subscribe(() => {
    //   // recargar lista si es necesario
    // });
  }
}
