using Flatie.Dto.Dto;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IHomeSpaceService
    {
        Task<IEnumerable<UserDto>> GetAllHomeSpaceMembers(int id);
    }
}