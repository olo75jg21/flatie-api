namespace Flatie.Db.Entities
{
    public class UserAppRole : Base
    {
        public string Name { get; set; } = null!;

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}