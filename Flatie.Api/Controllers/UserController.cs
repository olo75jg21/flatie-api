using Flatie.Api.Controllers.Interfaces;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller, IUserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetSingle(int id)
        {
            var user = await _userService.GetSingle(id);

            if (user is null)
            {
                return NoContent();
            }

            return user;
        }

        [HttpGet("WithDetails/{id}")]
        public async Task<ActionResult<UserDetailDto>> GetSingleWithDetails(int id)
        {
            var user = await _userService.GetSingleWithDetails(id);

            if (user is null)
            {
                return NoContent();
            }

            return user;
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
        {
            var users = await _userService.GetAll();

            if (users is null)
            {
                return NoContent();
            }

            return Ok(users);
        }

        [HttpGet("AllWithDetails")]
        public async Task<ActionResult<IEnumerable<UserDetailDto>>> GetAllWithDetails()
        {
            var users = await _userService.GetAllWithDetails();

            if (users is null)
            {
                return NoContent();
            }

            return Ok(users);
        }

        [HttpGet("{userId}/HomeSpaces")]
        public async Task<ActionResult<IEnumerable<HomeSpaceDto>>> GetUserHomeSpaces(int userId)
        {
            try
            {
                var homeSpaces = await _userService.GetUserHomeSpaces(userId);

                return Ok(homeSpaces);
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong {ex}");
            }
        }
    }
}