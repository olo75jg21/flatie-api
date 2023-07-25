namespace Flatie.Dto.Dto
{
    public class UserAppRoleDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Navigation Properties
        public List<UserDto>? Users { get; set; }
    }
}