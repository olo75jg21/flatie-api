using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("Notification")]
    public class Notification : Base
    {
        public string Message { get; set; } = null!;
        public bool read { get; set; } = false;

        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? NotificationTypeId { get; set; }

        [ForeignKey("NotificationTypeId")]
        public NotificationType? Type { get; set; } = null!;

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }
    }
}