using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class ReadDataLibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;

        public string Autor { get; set; } = null!;

        public string Publicador { get; set; } = null!;

        public string Categoria { get; set; } = null!;

        public string Formato { get; set; } = null!;

        public string? Idioma { get; set; }

        public int? NumeroPaginas { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public string? Descripcion { get; set; }
    }
}
