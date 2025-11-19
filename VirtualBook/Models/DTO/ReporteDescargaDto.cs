using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
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
