namespace API_Sistema_Tiquetes.Entidades
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public int IdCliente { get; set; }
        public int Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}
