namespace API_Sistema_Tiquetes.Entidades
{
    public class UsuarioTecnico
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int Estado { get; set; }
        public string Cedula { get; set; }
        public string Contrasena { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
    }

    public class InicioSesion
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
