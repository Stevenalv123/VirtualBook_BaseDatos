using Microsoft.AspNetCore.Mvc;

namespace VirtualBook_API.DTO
{
    public class LibroUploadRequest
    {
        [FromForm]
        public string Titulo { get; set; } = string.Empty;

        [FromForm]
        public int IdCategoria { get; set; }

        [FromForm]
        public int IdFormato { get; set; }

        [FromForm]
        public int IdIdioma { get; set; }

        [FromForm]
        public List<int> IdsAutores { get; set; } = new List<int>();

        [FromForm]
        public string? Descripcion { get; set; }

        [FromForm]
        public int? NumeroPaginas { get; set; }

        // Archivos
        public IFormFile ArchivoPDF { get; set; } = null!;
        public IFormFile Portada { get; set; } = null!;
    }
}
