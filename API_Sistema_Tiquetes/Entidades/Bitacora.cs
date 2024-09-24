namespace API_Sistema_Tiquetes.Entidades
{
    public class Bitacora
    {
        public int Id { get; set; }
        public int IdTiquete { get; set; }
        public int IdUsuario { get; set; }
        public string Accion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
