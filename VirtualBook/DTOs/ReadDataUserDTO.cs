using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.DTOs
{
    public class ReadDataUserDTO
    {
        public int Id { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string CorreoElectronico { get; set; } = null!;

        public byte[]? FotoPerfil { get; set; }

        public string Rol { get; set; } = null!;

        public DateTime? FechaNacimiento { get; set; }

        public string? Genero { get; set; }
    }
}
