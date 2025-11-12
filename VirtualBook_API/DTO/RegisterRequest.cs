using System.ComponentModel.DataAnnotations;

namespace VirtualBook_API.DTO
{
    public class RegisterRequest
    {
        [Required, MaxLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required, MaxLength(100), EmailAddress]
        public string Correo_Electronico { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Contrasena { get; set; } = string.Empty;

        [Required, Range(1, 3)]
        public int IdRol { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(10)]
        public string Genero { get; set; } = string.Empty;
    }
}
