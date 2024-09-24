namespace API_Sistema_Tiquetes.Entidades
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; } // Ubicacion
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        public int IdUsuario { get; set; } // Responsable Bodega
        public int IdCliente { get; set; }
        public string Telefono { get; set; }
    }
}
