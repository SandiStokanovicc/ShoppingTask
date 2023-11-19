namespace TactaShoppingTask.DAL.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; } = 3;
        public List<ShoppingList> ShoppingList { get; set; }
    }
}
