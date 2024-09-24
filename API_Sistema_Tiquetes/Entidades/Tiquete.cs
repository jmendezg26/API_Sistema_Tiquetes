namespace API_Sistema_Tiquetes.Entidades
{
    public class Tiquete
    {
        public int IdTiquete { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public int IdContrato { get; set; }
        public string NumeroCaso { get; set; }
        public string NombreContacto { get; set; }
        public string CorreoContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string Titulo { get; set; }
        public string Detalle { get; set; }
        public int IdTipoPeticion { get; set; }
        public int IdTipoServicio { get; set; }
        public int Estado { get; set; }
        public string DetalleCierre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaCierre { get; set; }
        public int IdPrioridad { get; set; }
        public string EquipoSerie { get; set; }
        public string EquipoActivo { get; set; }
    }

}
