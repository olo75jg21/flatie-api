using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("Guest")]
    public class Guest : Base
    {
        public int HomeSpaceId { get; set; }
        public int InvitedByUserId { get; set; }
        public string Name { get; set; } = null!;

        public DateTime start { get; set; }
        public DateTime end { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }

        [ForeignKey("InvitedByUserId")]
        public User? User { get; set; }
    }
}