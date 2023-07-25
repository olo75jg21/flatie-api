using System.ComponentModel.DataAnnotations;

namespace Flatie.Db.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}