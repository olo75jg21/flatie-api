using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("QuietHourImportance")]
    public class QuietHourImportance : Base
    {
        public int Rank { get; set; }

        public ICollection<QuietHour> QuietHours { get; set; } = new List<QuietHour>();
    }
}