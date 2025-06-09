import { Component, inject } from '@angular/core';

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
import { EmpleadoService } from '../../services/empleado.service';
import { EmpleadoResponse } from '../../models/empleado-response';
import { CommonModule } from '@angular/common';
import { EmpleadoDialogComponent } from './components/empleado-dialog/empleado-dialog.component';
import { ModoDialog } from '../../enums/modo-dialog';
import { EmpleadoRequest } from '../../models/empleado-request';

@Component({
  selector: 'app-empleados',
  imports: [
    CommonModule,
    TableModule,
    ButtonModule,
    InputTextModule,
    CardModule,
    ToolbarModule,
    IconFieldModule,
    InputIconModule,
    Tag,
    EmpleadoDialogComponent
  ],
  templateUrl: './empleados.component.html',
})
export class EmpleadosComponent {

  _empleadoService = inject(EmpleadoService);

  empleados: EmpleadoResponse[] = [];

  modoDialog: ModoDialog = ModoDialog.Crear;

  mostrarDialog: boolean = false;

  empleadoSeleccionado: EmpleadoResponse | null = null;

  ngOnInit() {
    this.cargarEmpleados();
  }

  cargarEmpleados() {
    this._empleadoService.obtenerEmpleados().subscribe((data) => {
      this.empleados = data;
      console.log('Empleados obtenidos:', this.empleados);
    });
  }

  guardarEmpleado(empleado: EmpleadoRequest) {
    if (this.modoDialog === ModoDialog.Crear) {
      this.onGuardarEmpleado(empleado);
    } else {
      if (empleado.id) {
        this.onEditarEmpleado(empleado.id, empleado);
      }
    }
    this.mostrarDialog = false;
  }

  abrirDialogCrearEmpleado() {
    this.mostrarDialog = true;
    this.modoDialog = ModoDialog.Crear;
    this.empleadoSeleccionado = null;
    console.log('Abriendo dialog para crear nuevo empleado', this.empleadoSeleccionado);
  }

  abrirDialogEditarEmpleado(empleado: EmpleadoResponse) {
    this.empleadoSeleccionado = empleado;
    this.mostrarDialog = true;
    this.modoDialog = ModoDialog.Editar;
  }

  getSeverity(estado: boolean) {
    return estado ? 'success' : 'danger';
  }


  eliminarEmpleado(empleadoId: number) {
    this._empleadoService.eliminarEmpleado(empleadoId).subscribe(() => {
      this.cargarEmpleados();
      console.log('Empleado eliminado:', empleadoId);
    }, error => {
      console.error('Error al eliminar el empleado:', error.error);
    });
  }

  onEditarEmpleado(id: number, empleadoEditado: EmpleadoRequest) {
    this._empleadoService.editarEmpleado(id, empleadoEditado).subscribe(response => {
      this.cargarEmpleados();
    }, error => {
      console.error('Error al actualizar el empleado:', error.error);
    });
  }

  onGuardarEmpleado(empleado: EmpleadoRequest) {
    this._empleadoService.crearEmpleado(empleado).subscribe((response) => {
      console.log('Empleado guardado con ID:', response.id);
      this.empleados.push(response);
    }, error => {
      console.error('Error al guardar el empleado:', error.error);
    });
  }
}
