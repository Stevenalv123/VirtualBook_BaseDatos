using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class LoginResponse
    {
        public bool Validacion { get; set; }
        public string Token { get; set; }
        public int IdUsuario { get; set; }
        public string Rol { get; set; }
    }
}
