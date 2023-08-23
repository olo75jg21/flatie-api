namespace Flatie.Dto.Fvo
{
    public class CreateInvitationsFvo
    {
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public int HomeSpaceId { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}