namespace Flatie.Dto
{
    public class Following
    {
        public int FollowingId { get; set; }
        public int FollowingUserId { get; set; }
        public int FollowedUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}