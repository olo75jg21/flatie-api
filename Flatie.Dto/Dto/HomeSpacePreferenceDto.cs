namespace Flatie.Dto.Dto
{
    public class HomeSpacePreferenceDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int UserId { get; set; }
        public int HomeSpaceId { get; set; }
    }
}