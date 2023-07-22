using System.ComponentModel.DataAnnotations.Schema;

namespace Flatie.Db.Entities
{
    [Table("ShoppingListCategory")]
    public class ShoppingListCategory : Base
    {
        public string Name { get; set; } = null!;

        public ICollection<ShoppingList> ShoppingLists { get; set; } = new List<ShoppingList>();
    }
}