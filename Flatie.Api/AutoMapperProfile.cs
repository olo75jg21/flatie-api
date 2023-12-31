using AutoMapper;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;

namespace Flatie.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterFvo, UserRegisterDto>().ReverseMap();
            CreateMap<UserLoginFvo, UserLoginDto>().ReverseMap();
            CreateMap<CreateInvitationsFvo, InvitationDto>().ReverseMap();

            CreateMap<UserRegisterDto, User>().ReverseMap();
            CreateMap<UserLoginDto, User>().ReverseMap();

            CreateMap<Guest, GuestDto>().ReverseMap();
            CreateMap<Guest, GuestDetailDto>().ReverseMap();

            CreateMap<HomeSpace, HomeSpaceDto>().ReverseMap();
            CreateMap<HomeSpace, HomeSpaceDetailDto>().ReverseMap();

            CreateMap<HomeSpaceMember, HomeSpaceMemberDto>().ReverseMap();
            CreateMap<HomeSpaceMember, HomeSpaceMemberDetailDto>().ReverseMap();

            CreateMap<HomeSpaceMemberRole, HomeSpaceMemberRoleDto>().ReverseMap();

            CreateMap<HomeSpacePreference, HomeSpacePreferenceDto>().ReverseMap();
            CreateMap<HomeSpacePreference, HomeSpacePreferenceDetailDto>().ReverseMap();

            CreateMap<Invitation, InvitationDto>().ReverseMap();
            // TODO add invitation details

            CreateMap<Notification, NotificationDto>().ReverseMap();
            CreateMap<Notification, NotificationDetailDto>().ReverseMap();

            CreateMap<NotificationType, NotificationTypeDto>().ReverseMap();
            CreateMap<NotificationType, NotificationTypeDetailDto>().ReverseMap();

            CreateMap<QuietHour, QuietHourDto>().ReverseMap();
            CreateMap<QuietHour, QuietHourDetailDto>().ReverseMap();

            CreateMap<QuietHourImportance, QuietHourImportanceDto>().ReverseMap();
            CreateMap<QuietHourImportance, QuietHourImportanceDetailDto>().ReverseMap();

            CreateMap<UserAppRole, UserAppRoleDto>().ReverseMap();
            CreateMap<UserAppRole, UserAppRoleDetailDto>().ReverseMap();

            CreateMap<ShoppingList, ShoppingListDto>().ReverseMap();
            CreateMap<ShoppingList, ShoppingListDetailDto>().ReverseMap();

            CreateMap<ShoppingListCategory, ShoppingListCategoryDto>().ReverseMap();
            CreateMap<ShoppingListCategory, ShoppingListCategoryDetailDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserDetailDto>().ReverseMap();

            CreateMap<UserAppRole, UserAppRoleDto>().ReverseMap();
            CreateMap<UserAppRole, UserAppRoleDetailDto>().ReverseMap();

            CreateMap<UserTask, UserTaskDto>().ReverseMap();
            CreateMap<UserTask, UserTaskDetailDto>().ReverseMap();
        }
    }
}