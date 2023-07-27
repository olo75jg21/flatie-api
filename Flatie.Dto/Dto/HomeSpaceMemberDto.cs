namespace Flatie.Dto.Dto
{
    public class HomeSpaceMemberDto
    {
        public int Id { get; set; }
        public DateTime JoinedAt { get; set; }
        public int HomeSpaceId { get; set; }
        public int UserId { get; set; }
        public int HomeSpaceMemberRoleId { get; set; }
    }
}