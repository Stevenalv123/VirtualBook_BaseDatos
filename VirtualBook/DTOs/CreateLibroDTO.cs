using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class CreateLibroDTO
    {
        public int IdLibro { get; set; }

        public string Titulo { get; set; } = null!;

        public int Autor { get; set; }

        public int Publicador { get; set; }

        public int IdCategoria { get; set; }

        public string Formato { get; set; } = null!;

        public byte[] ArchivoPdf { get; set; } = null!;

        public byte[] Portada { get; set; } = null!;

        public string? Idioma { get; set; }

        public int? NumeroPaginas { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public string? Descripcion { get; set; }
    }
}
