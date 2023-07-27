namespace Flatie.Dto.Dto
{
    public class GuestDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int HomeSpaceId { get; set; }
        public int InvitedByUserId { get; set; }
    }
}