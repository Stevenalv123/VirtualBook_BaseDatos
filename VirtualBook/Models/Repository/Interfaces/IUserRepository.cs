using VirtualBook.Models.DTO;

namespace VirtualBook.Models.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<LoginResponse> ValidateCredentialsAsync(string email, string password);
        Task<LoginResponse> GetMyProfileAsync();
    }
}
