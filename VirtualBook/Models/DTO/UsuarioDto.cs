using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Models.DTO
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo_Electronico { get; set; }
        public string NombreRol { get; set; }
        public string? FotoPerfil { get; set; }
        public bool Estado { get; set; }
    }
}
