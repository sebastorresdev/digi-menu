export interface EmpleadoResponse {
  id: number;
  nombres: string;
  apellidos: string;
  tipoDocumento: string;
  numeroDocumento: string;
  fechaNacimiento: Date | null;
  numeroTelefono: string | null;
  email: string | null;
  direccion: string | null;
  fechaCreacion: Date;
  estado: boolean;
}
