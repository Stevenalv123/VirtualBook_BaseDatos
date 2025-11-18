using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class LibroDetalleDTO
    {
        public int IdLibro { get; set; }
        public string? Titulo { get; set; }
        public string? Portada { get; set; }
        public string? ArchivoPDF { get; set; } // Esta es la RUTA
        public string? Descripcion { get; set; }
        public int? NumeroPaginas { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string? NombreCategoria { get; set; }
        public string? NombreFormato { get; set; }
        public string? NombreIdioma { get; set; }
        public string? PublicadorNombre { get; set; }
        public string? PublicadorFotoPerfil { get; set; }
        public int Descargas { get; set; }
        public int PublicadorId { get; set; }
        public string? Autores { get; set; }
    }
}
