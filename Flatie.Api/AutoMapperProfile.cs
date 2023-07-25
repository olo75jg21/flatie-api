using AutoMapper;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;

namespace Flatie.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserDetailDto>();

            CreateMap<UserAppRole, UserAppRoleDto>();
            CreateMap<UserAppRole, UserAppRoleDetailDto>();

            CreateMap<Notification, NotificationDto>();
            CreateMap<Notification, NotificationDetailDto>();

            CreateMap<ShoppingList, ShoppingListDto>();
            CreateMap<ShoppingList, ShoppingListDetailDto>();

            CreateMap<ShoppingListCategory, ShoppingListCategoryDto>();
            CreateMap<ShoppingListCategory, ShoppingListCategoryDetailDto>();

            CreateMap<QuietHour, QuietHourDto>();
            CreateMap<QuietHour, QuietHourDetailDto>();

            CreateMap<QuietHourImportance, QuietHourImportanceDto>();
            CreateMap<QuietHourImportance, QuietHourImportanceDetailDto>();

            CreateMap<UserTask, UserTaskDto>();
            CreateMap<UserTask, UserTaskDetailDto>();

            CreateMap<HomeSpace, HomeSpaceDto>();
            CreateMap<HomeSpace, HomeSpaceDetailDto>();

            CreateMap<HomeSpaceMember, HomeSpaceMemberDto>();
            CreateMap<HomeSpaceMember, HomeSpaceMemberDetailDto>();
        }
    }
}