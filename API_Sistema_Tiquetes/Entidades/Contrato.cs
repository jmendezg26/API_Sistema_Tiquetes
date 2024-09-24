namespace API_Sistema_Tiquetes.Entidades
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public string NombreContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int Cliente { get; set; }
        public string Detalle { get; set; }
        public int IdUsuario { get; set; } //Consultor
    }
}
