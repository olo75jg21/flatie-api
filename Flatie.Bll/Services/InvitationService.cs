using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;
using Flatie.Shared.Enums;

namespace Flatie.Bll.Services
{
    public class InvitationService : IInvitationService
    {
        protected readonly IHomeSpaceRepository _homeSpaceRepository;
        protected readonly IHomeSpaceMemberRepository _homeSpaceMemberRepository;
        protected readonly IInvitationRepository _invitationRepository;
        protected readonly IUserRepository _userRepository;
        protected readonly IMapper _mapper;

        public InvitationService(
            IMapper mapper,
            IHomeSpaceRepository homeSpaceRepository,
            IHomeSpaceMemberRepository homeSpaceMemberRepository,
            IInvitationRepository invitationRepository,
            IUserRepository userRepository
        )
        {
            _mapper = mapper;
            _homeSpaceRepository = homeSpaceRepository;
            _homeSpaceMemberRepository = homeSpaceMemberRepository;
            _invitationRepository = invitationRepository;
            _userRepository = userRepository;
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
                throw new Exception(ex.Message);
            }
        }

        public async Task AcceptInvitation(AcceptInvitationFvo acceptInvitationFvo)
        {
            try
            {
                var invitationEntity = await _invitationRepository.GetByIdAsync(acceptInvitationFvo.InvitationId) ?? throw new KeyNotFoundException();

                invitationEntity.Status = InvitationStatus.Accepted;

                var homeSpaceMember = new HomeSpaceMember
                {
                    HomeSpaceId = acceptInvitationFvo.HomeSpaceId,
                    UserId = acceptInvitationFvo.RecipientUserId,
                    JoinedAt = DateTime.UtcNow
                };

                await _homeSpaceMemberRepository.AddAsync(homeSpaceMember);
                await _homeSpaceMemberRepository.SaveChangesAsync();

                _invitationRepository.Update(invitationEntity);
                await _invitationRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

// {
//   "senderUserId": 2,
//   "recipientUserId": 3,
//   "homeSpaceId": 1,
//   "homeSpaceMemberRoleId": 2,
//   "expiresAt": "2023-08-25T19:57:49.679Z"
// }