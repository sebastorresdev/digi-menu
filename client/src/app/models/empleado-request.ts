export interface EmpleadoRequest {
  id?: number | null;
  nombres: string;
  apellidos: string;
  email?: string | null;
  direccion?: string | null;
  fechaNacimiento?: Date | null;
  tipoDocumento: string;
  numeroDocumento: string;
  numeroTelefono?: string | null;
}
