import { Component, effect, input, model, output } from '@angular/core';

// PrimeNG
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { DatePickerModule } from 'primeng/datepicker';
import { Select } from 'primeng/select';
import { ButtonModule } from 'primeng/button';
import { PasswordModule } from 'primeng/password';
import { TextareaModule } from 'primeng/textarea';
import { CalendarModule } from 'primeng/calendar';

// Proyecto
import { ModoDialog } from '../../../../enums/modo-dialog';
import { EmpleadoResponse } from '../../../../models/empleado-response';
import { EmpleadoRequest } from '../../../../models/empleado-request';


export const TipoDocumentoOptions = [
  { label: 'DNI', value: 'DNI' },
  { label: 'Carnet de Extranjería', value: 'CE' },
  { label: 'Pasaporte', value: 'PASS' }
];


@Component({
  selector: 'app-empleado-dialog',
  templateUrl: './empleado-dialog.component.html',
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
  ],
})

export class EmpleadoDialogComponent {

  visible = model<boolean>(false);

  modoDialog = input.required<ModoDialog>();

  empleado = model<EmpleadoResponse | null>();

  tipoDocumentoOptions = TipoDocumentoOptions;

  guardar = output<EmpleadoRequest>();

  cancelarDialog = output<void>();

  empleadoForm: FormGroup = new FormGroup({
    nombres: new FormControl('', [Validators.required, Validators.minLength(3)]),
    apellidos: new FormControl('', [Validators.required, Validators.minLength(6)]),
    email: new FormControl(null),
    direccion: new FormControl(null),
    fechaNacimiento: new FormControl(null),
    tipoDocumento: new FormControl(null, Validators.required),
    numeroDocumento: new FormControl(null, [Validators.required, Validators.minLength(6)]),
    numeroTelefono: new FormControl(null),
  });

  constructor() {
    effect(() => {
      const empleado = this.empleado();
      if (empleado) {
        this.empleadoForm.patchValue({
          nombres: empleado.nombres,
          apellidos: empleado.apellidos,
          email: empleado.email,
          direccion: empleado.direccion,
          fechaNacimiento: empleado.fechaNacimiento ? new Date(empleado.fechaNacimiento) : null,
          // fechaNacimiento: empleado.fechaNacimiento,
          tipoDocumento: empleado.tipoDocumento,
          numeroDocumento: empleado.numeroDocumento,
          numeroTelefono: empleado.numeroTelefono,
        });
      } else {
        this.empleadoForm.reset();
      }
    });
  }

  guardarEmpleado() {
    if (this.empleadoForm.invalid) {
      this.empleadoForm.markAllAsTouched();
      return;
    }

    this.visible.set(false);

    const nuevoEmpleado: EmpleadoRequest = {
      id: this.empleado()?.id ?? null,
      nombres: this.empleadoForm.value.nombres,
      apellidos: this.empleadoForm.value.apellidos,
      email: this.empleadoForm.value.email,
      direccion: this.empleadoForm.value.direccion,
      fechaNacimiento: this.empleadoForm.value.fechaNacimiento,
      tipoDocumento: this.empleadoForm.value.tipoDocumento,
      numeroDocumento: this.empleadoForm.value.numeroDocumento,
      numeroTelefono: this.empleadoForm.value.numeroTelefono,
    };

    this.guardar.emit(nuevoEmpleado);
  }

  obtenerHeaderDialog() {
    return this.modoDialog() === ModoDialog.Crear ? 'Crear Empleado' : 'Editar Empleado';
  }

  onCancelar() {
    this.cancelarDialog.emit();
  }
}
