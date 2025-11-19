using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class ResenaDTO
    {
        public string NombreUsuario { get; set; }
        public string FotoPerfil { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaReseña { get; set; }
    }
}
