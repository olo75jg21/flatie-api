using AutoMapper;
using Flatie.Dal.Repositories;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Dto.Dto;

namespace Flatie.Bll.Services
{
    public class UserAppRoleService : IUserAppRoleService
    {
        private readonly IMapper _mapper;
        private readonly IUserAppRoleRepository _userAppRoleRepository;

        public UserAppRoleService(IMapper mapper, IUserAppRoleRepository userAppRoleRepository)
        {
            _mapper = mapper;
            _userAppRoleRepository = userAppRoleRepository;
        }

        public async Task<IEnumerable<UserAppRoleDto>> GetAll()
        {
            var userAppRoles = await _userAppRoleRepository.GetAllAsync();
            return userAppRoles.Select(e => _mapper.Map<UserAppRoleDto>(e));
        }
    }
}