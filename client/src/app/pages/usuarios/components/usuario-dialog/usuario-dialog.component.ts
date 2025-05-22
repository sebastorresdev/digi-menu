import { Component, EventEmitter, Input, Output } from '@angular/core';

import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { CalendarModule } from 'primeng/calendar';
import { DropdownModule } from 'primeng/dropdown';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { TextareaModule } from 'primeng/textarea';

@Component({
  selector: 'app-usuario-dialog',
  imports: [
    CommonModule,
    FormsModule,
    DialogModule,
    InputTextModule,
    CalendarModule,
    DropdownModule,
    ButtonModule,
    PasswordModule,
    TextareaModule
  ],
  templateUrl: './usuario-dialog.component.html',
})
export class UsuarioDialogComponent {
  @Input() visible: boolean = false;
  @Output() visibleChange = new EventEmitter<boolean>();
  @Output() guardar = new EventEmitter<any>(); // Puedes tipar con `UsuarioDto` si lo tienes

  usuario: any = {
    nombres: '',
    apellidos: '',
    username: '',
    direccion: '',
    fechaNacimiento: null,
    tipoDocumento: '',
    numeroDocumento: '',
    hashPassword: '',
    rolId: null,
    estado: true,
  };

  tiposDocumento: string[] = ['DNI', 'Pasaporte', 'Carné de Extranjería']; // puedes ajustar

  cerrar() {
    this.visible = false;
    this.visibleChange.emit(false);
  }

  guardarUsuario() {
    this.guardar.emit(this.usuario);
    this.cerrar();
  }

  roles = [
  { label: 'Administrador', value: 'administrador' },
  { label: 'Cocinero', value: 'cocinero' },
  { label: 'Moso', value: 'moso' }
];
}
