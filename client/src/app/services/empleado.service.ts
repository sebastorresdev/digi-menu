import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EmpleadoResponse } from '../models/empleado-response';
import { EmpleadoRequest } from '../models/empleado-request';
import { EmpleadoNombreDniResponse } from '../models/empleado-nombre-dni-response';

@Injectable({
  providedIn: 'root'
})
export class EmpleadoService {

  private apiUrl = ' https://localhost:7104/empleados';

  constructor(private http: HttpClient) { }

  obtenerEmpleados(): Observable<EmpleadoResponse[]> {
    return this.http.get<EmpleadoResponse[]>(`${this.apiUrl}`);
  }

  obtenerNombreDniEmpleados(): Observable<EmpleadoNombreDniResponse[]> {
    return this.http.get<EmpleadoNombreDniResponse[]>(`${this.apiUrl}/nombre-dni`);
  }

  crearEmpleado(empleado: EmpleadoRequest): Observable<EmpleadoResponse> {
    return this.http.post<EmpleadoResponse>(`${this.apiUrl}`, empleado);
  }

  editarEmpleado(id: number, empleado: EmpleadoRequest): Observable<EmpleadoResponse> {
    return this.http.put<EmpleadoResponse>(`${this.apiUrl}/${id}`, empleado);
  }

  eliminarEmpleado(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
