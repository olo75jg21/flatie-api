using Flatie.Api.Controllers.Interfaces;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeSpaceController : Controller, IHomeSpaceController
    {
        private readonly ILogger<HomeSpaceController> _logger;
        private readonly IHomeSpaceService _homeSpaceService;

        public HomeSpaceController(ILogger<HomeSpaceController> logger, IHomeSpaceService homeSpaceService)
        {
            _logger = logger;
            _homeSpaceService = homeSpaceService;
        }

        [HttpGet("UserHomespaces/{id}")]
        public async Task<ActionResult<IEnumerable<HomeSpaceDto>>> GetUserHomeSpaces(int id)
        {
            var response = await _homeSpaceService.GetUserHomeSpaces(id);

            return Ok(response);
        }

        [HttpGet("{homeSpaceId}/members")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllHomeSpaceMembers(int homeSpaceId)
        {
            try
            {
                var homeSpaceMembers = await _homeSpaceService.GetAllHomeSpaceMembers(homeSpaceId);

                if (homeSpaceMembers is null)
                {
                    return NoContent();
                }

                return Ok(homeSpaceMembers);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}