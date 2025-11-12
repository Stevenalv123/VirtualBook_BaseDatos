namespace VirtualBook.DTOs
{
    public class ReadUsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string CorreoElectronico { get; set; } = null!;

        public byte[]? FotoPerfil { get; set; }

        public int Rol { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? Genero { get; set; }
    }
}
