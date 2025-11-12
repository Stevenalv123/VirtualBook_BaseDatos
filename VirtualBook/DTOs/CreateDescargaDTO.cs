namespace VirtualBook.DTOs
{
    public class CreateDescargaDTO
    {
        public int Id { get; set; }
        public int Usuario { get; set; }
        public int Libro { get; set; }
        public DateTime FechaDescarga { get; set; }
    }
}
