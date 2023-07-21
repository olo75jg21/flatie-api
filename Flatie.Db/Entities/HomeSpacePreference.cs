using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("HomeSpacePreference")]
    public class HomeSpacePreference : Base
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int UserId { get; set; }
        public int HomeSpaceId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }
    }
}