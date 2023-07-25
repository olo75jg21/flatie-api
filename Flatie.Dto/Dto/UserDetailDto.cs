namespace Flatie.Dto.Dto
{
    public class UserDetailDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!; // TODO do not send
        public int? UserAppRoleId { get; set; }

        // Navigation Properties
        public UserAppRoleDto? UserAppRole { get; set; }
        public List<NotificationDto>? Notifications { get; set; }
        public List<ShoppingListDto>? ShoppingLists { get; set; }
        public List<QuietHourDto>? QuietHours { get; set; }
        public List<GuestDto>? Guests { get; set; }
        public List<UserTaskDto>? UserTasks { get; set; }
        public List<HomeSpaceDto>? HomeSpaces { get; set; }
        public List<HomeSpaceMemberDto>? HomeSpaceMembers { get; set; }
    }
}