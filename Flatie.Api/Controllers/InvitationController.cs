using Flatie.Api.Controllers.Interfaces;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvitationController : Controller, IInvitationController
    {
        protected readonly IInvitationService _invitationService;

        public InvitationController(IInvitationService invitationService)
        {
            _invitationService = invitationService;
        }

        [HttpGet("{userId}/All")]
        public async Task<ActionResult<IEnumerable<InvitationDto>>> GetUserInvitations(int userId)
        {
            try
            {
                var userInvitations = await _invitationService.GetUserInvitations(userId);
                return Ok(userInvitations);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("Send")]
        public async Task<ActionResult<bool>> SendInvitation([FromBody] CreateInvitationsFvo createInvitationsFvo)
        {
            try
            {
                var result = await _invitationService.SendInvitation(createInvitationsFvo);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong: {ex}");
            }
        }

        [HttpPost("Accept/{invitationId}")]
        public async Task<ActionResult> AcceptInvitation(int invitationId)
        {
            try
            {
                await _invitationService.AcceptInvitation(invitationId);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong {ex}");
            }
        }
    }
}