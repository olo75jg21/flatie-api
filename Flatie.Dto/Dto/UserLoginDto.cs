namespace Flatie.Dto.Dto
{
    public class UserLoginDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}