using Flatie.Shared.Enums;

namespace Flatie.Dto.Dto
{
    public class InvitationDto
    {
        public int Id { get; set; }
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public int HomeSpaceId { get; set; }
        public InvitationStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}