namespace VirtualBook.Models.DTO
{
    public class NotificacionDTO
    {
        public int IdNotificacion { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public string TipoNotificacion { get; set; } = string.Empty;
        public DateTime FechaNotificacion { get; set; }
        public bool Leido { get; set; }
        public int? IdLibro { get; set; }
    }
}
