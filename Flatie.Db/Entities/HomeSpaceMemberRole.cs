namespace Flatie.Db.Entities
{
    public class HomeSpaceMemberRole : Base
    {
        public string Role { get; set; } = null!;

        public ICollection<HomeSpaceMember> HomeSpaceMembers { get; set; } = new List<HomeSpaceMember>();
    }
}