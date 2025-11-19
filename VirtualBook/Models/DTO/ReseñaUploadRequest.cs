using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class ReseñaUploadRequest
    {
        public int IdLibro { get; set; }
        public string Comentario { get; set; }
    }
}
