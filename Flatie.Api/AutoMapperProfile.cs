using AutoMapper;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;

namespace Flatie.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserAppRoleDto, UserAppRole>().ReverseMap();
        }
    }
}