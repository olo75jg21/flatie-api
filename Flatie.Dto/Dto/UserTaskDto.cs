namespace Flatie.Dto.Dto
{
    public class UserTaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public int RewardPoints { get; set; }
        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
    }
}