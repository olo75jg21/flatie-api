using Flatie.Api.Controllers.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvitationController : Controller, IInvitationController
    {
        [HttpGet("{userId}/AllUserInvitations")]
        public Task<ActionResult<IEnumerable<InvitationDto>>> GetUserInvitations(int userId)
        {
            throw new NotImplementedException();
        }
    }
}