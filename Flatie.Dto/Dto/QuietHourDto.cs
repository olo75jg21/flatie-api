namespace Flatie.Dto.Dto
{
    public class QuietHourDto
    {
        public int Id { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? QuietHourImportanceId { get; set; }
    }
}