namespace Flatie.Dto.Dto
{
    public class QuietHourDetailDto
    {
        public int Id { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? QuietHourImportanceId { get; set; }

        // Navigation Properties
        public UserDto? User { get; set; }
        public HomeSpaceDto? HomeSpace { get; set; }
        public QuietHourImportanceDto? Importance { get; set; }
    }
}