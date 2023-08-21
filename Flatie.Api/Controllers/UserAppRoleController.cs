using Flatie.Bll.Services;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAppRoleController : Controller, IUserAppRoleController
    {
        private readonly ILogger<UserAppRoleController> _logger;
        private readonly IUserAppRoleService _userAppRoleService;

        public UserAppRoleController(ILogger<UserAppRoleController> logger, IUserAppRoleService userAppRoleService)
        {
            _logger = logger;
            _userAppRoleService = userAppRoleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserAppRoleDto>>> UserAppRoles()
        {
            var userAppRoles = await _userAppRoleService.GetAll();
            return Ok(userAppRoles);
        }
    }
}