export interface Usuario {
  id: number;
  nombres: string;
  apellidos: string;
  direccion: string;
  fechaNacimiento: string | null;  // o Date, si la parseas
  fechaCreacion: string;           // o Date, si la parseas
  username: string;
  numeroDocumento: string;
  tipoDocumento: string;
  estado: boolean;
}
