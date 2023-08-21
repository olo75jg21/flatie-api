using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IInvitationController
    {
        Task<ActionResult<IEnumerable<InvitationDto>>> GetUserInvitations(int userId);
    }
}