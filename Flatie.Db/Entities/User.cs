using System.ComponentModel.DataAnnotations.Schema;
using Flatie.Shared.Enums;

namespace Flatie.Db.Entities
{
    [Table("User")]
    public class User : Base
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        // TODO change it to table
        public UserRole Role { get; set; } = UserRole.Member;

        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<ShoppingList> ShoppingLists { get; set; } = new List<ShoppingList>();
        public ICollection<QuietHour> QuietHours { get; set; } = new List<QuietHour>();
        public ICollection<Guest> Guests { get; set; } = new List<Guest>();
        public ICollection<UserTask> UserTasks { get; set; } = new List<UserTask>();

        public ICollection<HomeSpace> HomeSpaces { get; set; } = new List<HomeSpace>();
        public ICollection<HomeSpaceMember> HomeSpaceMembers { get; set; } = new List<HomeSpaceMember>();
    }
}