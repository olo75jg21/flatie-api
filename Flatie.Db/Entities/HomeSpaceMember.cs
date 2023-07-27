using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    public class HomeSpaceMember : Base
    {
        public DateTime JoinedAt { get; set; }

        public int HomeSpaceId { get; set; }
        public int UserId { get; set; }
        public int HomeSpaceMemberRoleId { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; } = null!;

        [ForeignKey("UserId")]
        public User? User { get; set; } = null!;

        [ForeignKey("HomeSpaceMemberRoleId")]
        public HomeSpaceMemberRole? HomeSpaceMemberRole { get; set; } = null!;
    }
}