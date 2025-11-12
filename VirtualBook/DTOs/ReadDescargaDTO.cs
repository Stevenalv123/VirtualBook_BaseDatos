namespace VirtualBook.DTOs
{
    public class ReadDescargaDTO
    {
        public int IdDescarga { get; set; }
        public string Usuario { get; set; } = null!;
        public string Libro { get; set; } = null!;
        public DateTime FechaDescarga { get; set; }
    }
}
