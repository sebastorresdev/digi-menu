import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from '../models/usuario';
import { Observable } from 'rxjs';
import { CrearUsuarioRequest } from '../models/crear-usuario-request';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private apiUrl = ' https://localhost:7104/usuarios';  // Cambia por tu URL real

  constructor(private http: HttpClient) { }

  obtenerUsuarios(): Observable<Usuario[]> {
    return this.http.get<Usuario[]>(this.apiUrl);
  }

  guardarUsuario(nuevoUsuario: CrearUsuarioRequest): Observable<number> {
    return this.http.post<number>(this.apiUrl, nuevoUsuario);
  }
}
