import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';

import { CommonModule } from '@angular/common';
import { AbstractControl, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { DatePickerModule } from 'primeng/datepicker';
import { Select } from 'primeng/select';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { TextareaModule } from 'primeng/textarea';
import { CalendarModule } from 'primeng/calendar';
import { AutoCompleteModule } from 'primeng/autocomplete';

// Proyecto
import { RolService } from '../../../../services/rol.service';
import { RolResponse } from '../../../../models/rol-response';
import { CrearUsuarioRequest } from '../../../../models/crear-usuario-request';
import { EmpleadoService } from '../../../../services/empleado.service';
import { EmpleadoNombreDniResponse } from '../../../../models/empleado-nombre-dni-response';

@Component({
  selector: 'app-usuario-dialog',
  templateUrl: './usuario-dialog.component.html',
  imports: [
    CommonModule,
    FormsModule,
    DialogModule,
    InputTextModule,
    Select,
    ButtonModule,
    DatePickerModule,
    PasswordModule,
    TextareaModule,
    CalendarModule,
    ReactiveFormsModule,
    AutoCompleteModule
  ],
})
export class UsuarioDialogComponent implements OnInit {
  @Input() visible: boolean = false;
  @Output() visibleChange = new EventEmitter<boolean>();
  @Output() guardarEvent = new EventEmitter<CrearUsuarioRequest>(); // Puedes tipar con `UsuarioDto` si lo tienes

  empleadoService = inject(EmpleadoService);

  rolService = inject(RolService);

  repetirPassword: string = '';

  usuarioForm: FormGroup = new FormGroup({
    username: new FormControl('', [Validators.required, Validators.minLength(3)]),
    password: new FormControl('', [Validators.required, Validators.minLength(6)]),
    repetirPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
    rol: new FormControl(null, Validators.required),
    empleado: new FormControl(null, Validators.required),
  }, {
    validators: [
      (FormGroup: AbstractControl) => {
        const password = FormGroup.get('password')?.value;
        const repetirPassword = FormGroup.get('repetirPassword')?.value;
        return password === repetirPassword ? null : { passwordsNotMatch: true };
      }
    ]
  });

  roles: RolResponse[] = [];

  empleados: EmpleadoNombreDniResponse[] = [];

  empleadosFiltrados: EmpleadoNombreDniResponse[] = [];

  buscarEmpleado(event: any) {
    const query = event.query.toLowerCase();
    this.empleadosFiltrados = this.empleados.filter(emp =>
      emp.nombreDni.toLowerCase().includes(query));
  }

  ngOnInit(): void {
    this.rolService.obtenerRoles().subscribe((data: RolResponse[]) => {
      this.roles = data;
    });

    this.empleadoService.obtenerNombreDniEmpleados().subscribe((data: EmpleadoNombreDniResponse[]) => {
      this.empleados = data;
    });
  }

  cerrar() {
      this.visible = false;
      this.visibleChange.emit(false);
    }

  guardar() {
      if(this.usuarioForm.invalid) {
      this.usuarioForm.markAllAsTouched();
      return;
    }

    console.log('Formulario válido:', this.usuarioForm.value);

    const nuevoUsuario: CrearUsuarioRequest = {
      username: this.usuarioForm.value.username,
      password: this.usuarioForm.value.password,
      repetirPassword: this.usuarioForm.value.repetirPassword,
      rolId: this.usuarioForm.value.rol.id,
      empleadoId: this.usuarioForm.value.empleado.id
    };

    this.guardarEvent.emit(nuevoUsuario);
    this.cerrar();
  }
}
