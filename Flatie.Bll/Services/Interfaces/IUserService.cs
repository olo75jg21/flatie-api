using Flatie.Dto.Dto;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetSingle(int id);
        Task<UserDetailDto> GetSingleWithDetails(int id);
        Task<IEnumerable<UserDto>> GetAll();
        Task<IEnumerable<UserDetailDto>> GetAllWithDetails();
    }
}