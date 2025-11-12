using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class CreateUserDTO
    {
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public byte[]? FotoPerfil { get; set; }
        public int Rol { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Genero { get; set; }
    }
}
