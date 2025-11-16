using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class LibroUploadModel
    {
        public string Titulo { get; set; }
        public int IdCategoria { get; set; }
        public int IdFormato { get; set; }
        public int IdIdioma { get; set; }
        public List<int> IdsAutores { get; set; }
        public string Descripcion { get; set; }
        public int? NumeroPaginas { get; set; }
        public string RutaArchivoPDF { get; set; }
        public string RutaArchivoPortada { get; set; }
    }
}
