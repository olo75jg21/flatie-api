namespace Flatie.Dto.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!; // TODO DO NOT SEND
        public int? UserAppRoleId { get; set; }
    }
}