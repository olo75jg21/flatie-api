namespace Flatie.Dto.Dto
{
    public class HomeSpaceMemberDto
    {
        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public DateTime JoinedAt { get; set; }
        public int HomeSpaceId { get; set; }
        public int UserId { get; set; }
    }
}