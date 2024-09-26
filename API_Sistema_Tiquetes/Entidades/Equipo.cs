namespace API_Sistema_Tiquetes.Entidades
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Serie { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string NumeroParte { get; set; } //Numero Lote
        public string Activo { get; set; }
        public int IdTipoEquipo { get; set; }
        public int IdBodega { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Descripcion { get; set; }
    }
}
