namespace Flatie.Dto.Dto
{
    public class NotificationTypeDetailDto
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = null!;

        // Navigation Properties
        public List<NotificationDto>? Notifications { get; set; }
    }
}