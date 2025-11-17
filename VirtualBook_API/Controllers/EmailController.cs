using Microsoft.AspNetCore.Mvc;
using VirtualBook_API.DTO;
using VirtualBook_API.Services;

namespace VirtualBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly EmailService _emailService;

        public EmailController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendEmail([FromBody] CreateEmailRequest request)
        {
            try
            {
                await _emailService.SendEmailAsync(request);
                return Ok("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al enviar el correo: {ex.Message}");
            }
        }
    }
}