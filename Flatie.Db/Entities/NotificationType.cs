using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("NotificationType")]
    public class NotificationType : Base
    {
        public string TypeName { get; set; } = null!;

        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}