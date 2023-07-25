namespace Flatie.Dto.Dto
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public bool Read { get; set; }
        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? NotificationTypeId { get; set; }
    }
}