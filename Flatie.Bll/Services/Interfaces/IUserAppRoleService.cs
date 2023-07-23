using Flatie.Dto.Dto;

namespace Flatie.Bll.Services
{
    public interface IUserAppRoleService
    {
        Task<IEnumerable<UserAppRoleDto>> GetAll();
    }
}