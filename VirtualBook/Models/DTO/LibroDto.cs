using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class LibroDto
    {
        public int IdLibro { get; set; }
        public string? Titulo { get; set; }

        // Uploads/portada.jpg
        public string? Portada { get; set; }
        public string? Descripcion { get; set; }
        public int? NumeroPaginas { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Descargas { get; set; }
        public string? NombreCategoria { get; set; }
        public string? NombreFormato { get; set; }
        public string? NombreIdioma { get; set; }
        public string? Publicador { get; set; }
        public string? Autores { get; set; }
    }
}
