using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("ShoppingList")]
    public class ShoppingList : Base
    {
        public string ItemName { get; set; } = null!;

        public int Amount { get; set; }
        public int? PurchasePrice { get; set; }

        public int? CategoryId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? RequestedByUserId { get; set; }
        public int? PucharsedByUserId { get; set; }

        [ForeignKey("CategoryId")]
        public ShoppingListCategory Category { get; set; } = null!;

        [ForeignKey("HomeSpaceId")]
        public HomeSpace? HomeSpace { get; set; }

        [ForeignKey("RequestedByUserId")]
        public User? RequestedByUser { get; set; }

        [ForeignKey("PucharsedByUserId")]
        public User? PuchasedByUser { get; set; }
    }
}