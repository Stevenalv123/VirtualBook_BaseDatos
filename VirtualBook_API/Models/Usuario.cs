using System.ComponentModel.DataAnnotations;

namespace VirtualBook_API.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required, MaxLength(50)]
        public string? Nombres { get; set; }
        [Required, MaxLength(50)]
        public string? Apellidos { get; set; }
        [Required, MaxLength(100), EmailAddress]
        public string? Correo_Electronico { get; set; }
        [Required, MaxLength(64)]
        public string? FotoPerfil { get; set; }
        [Required, Range(1,3)]
        public int IdRol { get; set; }
        public string NombreRol { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string? Genero { get; set; }
    }
}
