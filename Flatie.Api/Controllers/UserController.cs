using Flatie.Api.Controllers.Interfaces;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller, IUserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
        {
            var users = await _userService.GetAll();

            return Ok(users);
        }

        [HttpGet("AllWithDetails")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllWithDetails()
        {
            var users = await _userService.GetAllWithDetails();

            return Ok(users);
        }

    }
}