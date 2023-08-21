using System.ComponentModel.DataAnnotations.Schema;
using Flatie.Shared.Enums;

namespace Flatie.Db.Entities
{
    [Table("Invitation")]
    public class Invitation : Base
    {
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public int HomeSpaceId { get; set; }
        public InvitationStatus Status { get; set; }
        public DateTime ExpiresAt { get; set; }

        [ForeignKey("SenderUserId")]
        public User SenderUser { get; set; } = null!;

        [ForeignKey("RecipientUserId")]
        public User RecipientUser { get; set; } = null!;

        [ForeignKey("HomeSpaceId")]
        public HomeSpace HomeSpace { get; set; } = null!;
    }

}