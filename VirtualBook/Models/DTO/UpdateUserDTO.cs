namespace VirtualBook.Models.DTO
{
    public class UpdateUserDTO
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string? RutaNuevaFoto { get; set; } 
    }
}
