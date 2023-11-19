namespace TactaShoppingTask.DAL.Models
{
    public class ShoppingList
    {
        public int ShopperId { get; set; }
        public Shopper Shopper { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
