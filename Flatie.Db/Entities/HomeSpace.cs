using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("HomeSpace")]
    public class HomeSpace : Base
    {
        public string Name { get; set; } = null!;

        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<ShoppingList> ShoppingLists { get; set; } = new List<ShoppingList>();
        public ICollection<QuietHour> QuietHours { get; set; } = new List<QuietHour>();
        public ICollection<Guest> Guests { get; set; } = new List<Guest>();
        public ICollection<UserTask> UserTasks { get; set; } = new List<UserTask>();

        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<HomeSpaceMember> HomeSpaceMembers { get; set; } = new List<HomeSpaceMember>();
    }
}