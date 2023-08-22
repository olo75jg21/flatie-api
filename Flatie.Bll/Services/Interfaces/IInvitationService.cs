using Flatie.Dto.Dto;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IInvitationService
    {
        Task<IEnumerable<InvitationDto>> GetUserInvitations(int userId);
    }
}