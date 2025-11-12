namespace VirtualBook.DTOs
{
    public class ReadVistaPreviaLibro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; } = null!;
        public string Autor { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public byte[] Portada { get; set; } = null!;
    }
}
