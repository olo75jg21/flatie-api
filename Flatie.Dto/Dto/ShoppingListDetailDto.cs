namespace Flatie.Dto.Dto
{
    public class ShoppingListDetailDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = null!;
        public int Amount { get; set; }
        public int PurchasePrice { get; set; }
        public int? CategoryId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? RequestedByUserId { get; set; }
        public int? PurchasedByUserId { get; set; }

        // Navigation Properties
        public ShoppingListCategoryDto? Category { get; set; }
        public HomeSpaceDto? HomeSpace { get; set; }
        public UserDto? RequestedByUser { get; set; }
        public UserDto? PurchasedByUser { get; set; }
    }
}