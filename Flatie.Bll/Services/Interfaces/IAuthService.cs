using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> Register(UserRegisterFvo user);
        Task<UserLoginDto> Login(UserLoginFvo user);
        Task<bool> UserExists(string username);
    }
}