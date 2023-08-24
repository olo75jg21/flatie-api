using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;

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

        public async Task<bool> SendInvitation(CreateInvitationsFvo createInvitationsFvo)
        {
            try
            {
                var invitationDto = _mapper.Map<InvitationDto>(createInvitationsFvo);
                var invitationEntity = _mapper.Map<Invitation>(invitationDto);

                await _invitationRepository.AddAsync(invitationEntity);
                await _invitationRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task AcceptInvitation(int invitationId)
        {

        }
    }
}