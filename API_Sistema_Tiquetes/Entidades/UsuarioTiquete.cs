namespace API_Sistema_Tiquetes.Entidades
{
    public class UsuarioTiquete
    {
        public int Id { get; set; }
        public string Usuario { get; set;}
        public int Tiquete { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
    }
}
