using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("QuietHour")]
    public class QuietHour : Base
    {
        public string Reason { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? QuietHourImportanceId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }

        [ForeignKey("QuietHourImportanceId")]
        public QuietHourImportance? Importance { get; set; }
    }
}