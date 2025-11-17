namespace VirtualBook.Models.DTO
{
    public class RegisterRequest
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Correo_Electronico { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string? FotoPerfil { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; } = string.Empty;
    }
}
