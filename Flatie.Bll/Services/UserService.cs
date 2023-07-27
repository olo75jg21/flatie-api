using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Dto.Dto;

namespace Flatie.Bll.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(e => _mapper.Map<UserDto>(e));
        }

        public async Task<IEnumerable<UserDetailDto>> GetAllWithDetails()
        {
            var users = await _userRepository.GetAllWithDetailsAsync();
            return users.Select(e => _mapper.Map<UserDetailDto>(e));
        }
    }
}