using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IInvitationService
    {
        Task<IEnumerable<InvitationDto>> GetUserInvitations(int userId);
        Task<bool> SendInvitation(CreateInvitationsFvo createInvitationsFvo);
    }
}