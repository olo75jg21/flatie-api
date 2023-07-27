using Flatie.Dto.Dto;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAll();
        Task<IEnumerable<UserDetailDto>> GetAllWithDetails();
    }
}