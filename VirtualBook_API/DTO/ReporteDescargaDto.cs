namespace VirtualBook_API.DTO
{
    public class ReporteDescargaDto
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Autores { get; set; }
        public int TotalDescargas { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
