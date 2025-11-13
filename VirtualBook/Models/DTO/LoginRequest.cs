using System.ComponentModel.DataAnnotations;

namespace VirtualBook.Models.DTO
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        public string Password { get; set; } = string.Empty;
    }
}
