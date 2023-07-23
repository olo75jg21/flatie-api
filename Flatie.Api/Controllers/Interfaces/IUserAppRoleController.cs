using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    public interface IUserAppRoleController
    {
        Task<ActionResult<IEnumerable<UserAppRoleDto>>> UserAppRoles();
    }
}