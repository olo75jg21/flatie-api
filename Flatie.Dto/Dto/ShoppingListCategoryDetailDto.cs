namespace Flatie.Dto.Dto
{
    public class ShoppingListCategoryDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Navigation Properties
        public List<ShoppingListDto>? ShoppingLists { get; set; }
    }
}