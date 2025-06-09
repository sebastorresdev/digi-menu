export interface CrearUsuarioRequest {
  username: string;
  password: string;
  repetirPassword: string;
  rolId: number;
  empleadoId: number;
}
