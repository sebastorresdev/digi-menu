import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RolResponse } from '../models/rol-response';

@Injectable({
  providedIn: 'root'
})
export class RolService {

  private apiUrl = ' https://localhost:7104/roles';

  constructor(private http: HttpClient) { }

  obtenerRoles(): Observable<RolResponse[]> {
    return this.http.get<RolResponse[]>(`${this.apiUrl}`);
  }
}
