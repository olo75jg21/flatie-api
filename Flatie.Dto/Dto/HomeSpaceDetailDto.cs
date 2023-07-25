namespace Flatie.Dto.Dto
{
    public class HomeSpaceDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Navigation Properties
        public ICollection<NotificationDto>? Notifications { get; set; }
        public ICollection<ShoppingListDto>? ShoppingLists { get; set; }
        public ICollection<QuietHourDto>? QuietHours { get; set; }
        public ICollection<GuestDto>? Guests { get; set; }
        public ICollection<UserTaskDto>? UserTasks { get; set; }
        public ICollection<UserDto>? Users { get; set; }
        public ICollection<HomeSpaceMemberDto>? HomeSpaceMembers { get; set; }
    }
}