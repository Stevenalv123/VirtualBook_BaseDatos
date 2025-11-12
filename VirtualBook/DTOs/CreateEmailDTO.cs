using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class CreateEmailDTO
    {
        public string EmailReceptor { get; set; } = null!;
        public string Tema { get; set; } = null!;
        public string Cuerpo { get; set; } = null!;
    }
}
