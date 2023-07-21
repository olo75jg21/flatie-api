using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("QuietHour")]
    public class QuietHour : Base
    {
        // TODO maybe add a QuietHoursReason table
        public string Reason { get; set; } = null!;

        // TODO add QuietHoursImportance table
        public string Importance { get; set; } = null!;

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int UserId { get; set; }
        public int HomeSpaceId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }
    }
}