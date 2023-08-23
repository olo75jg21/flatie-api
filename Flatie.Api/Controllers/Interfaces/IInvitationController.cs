using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IInvitationController
    {
        Task<ActionResult<IEnumerable<InvitationDto>>> GetUserInvitations(int userId);
        Task<ActionResult<bool>> SendInvitation(CreateInvitationsFvo createInvitationsFvo);
    }
}