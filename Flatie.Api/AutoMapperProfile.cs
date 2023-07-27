using AutoMapper;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;

namespace Flatie.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDetailDto>().ReverseMap();

            CreateMap<UserAppRole, UserAppRoleDto>().ReverseMap();
            CreateMap<UserAppRole, UserAppRoleDetailDto>().ReverseMap();

            CreateMap<Notification, NotificationDto>().ReverseMap();
            CreateMap<Notification, NotificationDetailDto>().ReverseMap();

            CreateMap<ShoppingList, ShoppingListDto>().ReverseMap();
            CreateMap<ShoppingList, ShoppingListDetailDto>().ReverseMap();

            CreateMap<ShoppingListCategory, ShoppingListCategoryDto>().ReverseMap();
            CreateMap<ShoppingListCategory, ShoppingListCategoryDetailDto>().ReverseMap();

            CreateMap<QuietHour, QuietHourDto>().ReverseMap();
            CreateMap<QuietHour, QuietHourDetailDto>().ReverseMap();

            CreateMap<QuietHourImportance, QuietHourImportanceDto>().ReverseMap();
            CreateMap<QuietHourImportance, QuietHourImportanceDetailDto>().ReverseMap();

            CreateMap<UserTask, UserTaskDto>().ReverseMap();
            CreateMap<UserTask, UserTaskDetailDto>().ReverseMap();

            CreateMap<HomeSpace, HomeSpaceDto>().ReverseMap();
            CreateMap<HomeSpace, HomeSpaceDetailDto>().ReverseMap();

            CreateMap<HomeSpaceMember, HomeSpaceMemberDto>().ReverseMap();
            CreateMap<HomeSpaceMember, HomeSpaceMemberDetailDto>().ReverseMap();

            CreateMap<HomeSpaceMemberRole, HomeSpaceMemberRoleDto>().ReverseMap();
        }
    }
}