using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Dto.Dto;

namespace Flatie.Bll.Services
{
    public class HomeSpaceService : IHomeSpaceService
    {
        private readonly IMapper _mapper;
        private readonly IHomeSpaceRepository _homeSpaceRepository;

        public HomeSpaceService(IMapper mapper, IHomeSpaceRepository homeSpaceRepository)
        {
            _mapper = mapper;
            _homeSpaceRepository = homeSpaceRepository;
        }

        public async Task<IEnumerable<UserDto>> GetAllHomeSpaceMembers(int homeSpaceId)
        {
            var homeSpaceMembers = await _homeSpaceRepository.GetHomeSpaceMembers(homeSpaceId);

            return homeSpaceMembers.Select(e => _mapper.Map<UserDto>(e));
        }
    }
}