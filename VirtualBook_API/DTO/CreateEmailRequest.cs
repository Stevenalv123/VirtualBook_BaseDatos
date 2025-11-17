namespace VirtualBook_API.DTO
{
    public class CreateEmailRequest
    {
        public string EmailReceptor { get; set; } = null!;
        public string Tema { get; set; }= null!;
        public string Cuerpo { get; set; } = null!;
    }
}
