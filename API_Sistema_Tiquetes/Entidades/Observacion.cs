namespace API_Sistema_Tiquetes.Entidades
{
    public class Observacion
    {
        public int IdObservacion { get; set; }
        public string Descripcion { get; set; }
        public int IdTiquete { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
    }

    public class ArchivosObservacion
    {
        public int Id { get; set; }
        public int IdObservacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Archivo { get; set; } //Ubicación en el FileServer

    }
}
