using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IInvitationService
    {
        Task<IEnumerable<InvitationDto>> GetUserInvitations(int userId);
        Task<bool> SendInvitation(CreateInvitationsFvo createInvitationsFvo);
        Task AcceptInvitation(AcceptInvitationFvo acceptInvitationFvo);
    }
}