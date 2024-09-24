namespace API_Sistema_Tiquetes.Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; } // Ubicacion
        public string Telefono { get; set; }
        public int IdProvincia { get; set; }
        public int IdCanton { get; set; }
        public int IdCliente { get; set; }
    }
}
