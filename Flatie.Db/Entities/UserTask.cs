using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("UserTask")]
    public class UserTask : Base
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public int RewardPoints { get; set; }

        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }
    }
}