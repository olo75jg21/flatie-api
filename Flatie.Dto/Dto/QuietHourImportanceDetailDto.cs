namespace Flatie.Dto.Dto
{
    public class QuietHourImportanceDetailDto
    {
        public int Id { get; set; }
        public int Rank { get; set; }

        // Navigation Properties
        public List<QuietHourDto>? QuietHours { get; set; }
    }
}