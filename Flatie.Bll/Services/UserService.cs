using System.Security.Claims;
using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Http;

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

        public async Task<UserDto> GetSingle(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDetailDto> GetSingleWithDetails(int id)
        {
            var user = await _userRepository.GetByIdWithDetailsAsync(id);

            return _mapper.Map<UserDetailDto>(user);
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

        public async Task<IEnumerable<HomeSpaceDto>> GetUserHomeSpaces(int userId)
        {
            var homeSpaceEntitiesList = await _userRepository.GetUserHomeSpacesAsync(userId);

            var homeSpaceDtoList = homeSpaceEntitiesList
                .Select(entity => _mapper.Map<HomeSpaceDto>(entity));

            return homeSpaceDtoList;
        }
    }
}