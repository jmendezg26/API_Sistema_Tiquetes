namespace API_Sistema_Tiquetes.Entidades
{
    public class EquipoCliente
    {
        public int Id { get; set; }
        public int IdEquipo { get; set; }
        public string Serie { get; set; }
        public string Activo { get; set; }
        public int IdContrato { get; set; }
        public int IdSucursal { get; set; }
        public int Bodega { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
