using AutoMapper;
using Flatie.Api.Controllers.Interfaces;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dto.Fvo;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller, IAuthController
    {
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public AuthController(IMapper mapper, IAuthService authService)
        {
            _mapper = mapper;
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<int>> Register(UserRegisterFvo userRegisterFvo)
        {
            if (userRegisterFvo is null)
            {
                return BadRequest();
            }

            try
            {
                var success = await _authService.Register(userRegisterFvo);

                if (success)
                {
                    return Ok(success);
                }

                return BadRequest();
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}