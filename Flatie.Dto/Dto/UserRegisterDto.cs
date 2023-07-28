namespace Flatie.Dto.Dto
{
    public class UserRegisterDto
    {
        public int Id { get; set; }

        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
    }
}