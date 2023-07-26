using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    public class HomeSpaceMember : Base
    {
        // TODO create a entity for Role
        public string Role { get; set; } = null!;
        public DateTime JoinedAt { get; set; }

        public int HomeSpaceId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; } = null!;

        [ForeignKey("UserId")]
        public User? User { get; set; } = null!;
    }
}