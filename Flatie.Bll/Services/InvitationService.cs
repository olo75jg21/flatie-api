using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Dto.Dto;

namespace Flatie.Bll.Services
{
    public class InvitationService : IInvitationService
    {
        protected readonly IInvitationRepository _invitationRepository;
        protected readonly IMapper _mapper;

        public InvitationService(IMapper mapper, IInvitationRepository invitationRepository)
        {
            _mapper = mapper;
            _invitationRepository = invitationRepository;
        }

        public async Task<IEnumerable<InvitationDto>> GetUserInvitations(int userId)
        {
            var userInvitationsEntitiesList = await _invitationRepository.FindByRecipientUserIdAsync(userId);

            var userInvitationsDtoList = userInvitationsEntitiesList.Select(i => _mapper.Map<InvitationDto>(i));

            return userInvitationsDtoList;
        }
    }
}