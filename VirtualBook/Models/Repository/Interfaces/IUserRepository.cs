using VirtualBook.Models.DTO;
using VirtualBook_API.DTO;

namespace VirtualBook.Models.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<LoginResponse> ValidateCredentialsAsync(string email, string password);
        Task<LoginResponse> GetMyProfileAsync();
        Task<bool> EnviarCorreo(string correo, string titulo, string cuerpo);
        Task<List<RolDTO>> GetRolesAsync();
        Task<bool> VerificarCorreoExiste(string correo);
        Task<bool> RegistrarUsuario(RegisterRequest _registerRequest);
        Task<List<UsuarioDto>> GetUsuariosAsync();
        Task<bool> CambiarEstadoUsuarioAsync(int idUsuario, bool nuevoEstado);
        Task<bool> UpdateProfileAsync(UpdateUserDTO updateData);
        Task<bool> ToggleSeguirUsuarioAsync(int idUsuarioASeguir);
        Task<bool> VerificarSiSigueAsync(int idUsuarioASeguir);
    }
}
