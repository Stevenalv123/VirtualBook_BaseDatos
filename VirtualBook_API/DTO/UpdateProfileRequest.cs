namespace VirtualBook_API.DTO
{
    public class UpdateProfileRequest
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public IFormFile? FotoPerfil { get; set; } 
    }
}
