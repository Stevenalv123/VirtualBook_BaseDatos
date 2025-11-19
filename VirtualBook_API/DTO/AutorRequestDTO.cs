using System.ComponentModel.DataAnnotations;

namespace VirtualBook_API.DTO
{
    public class AutorRequestDTO
    {
        [Required]
        public string NombreAutor { get; set; } = string.Empty;
        public string? Biografia { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Nacionalidad { get; set; }
    }
}
