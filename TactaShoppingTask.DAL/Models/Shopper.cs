namespace TactaShoppingTask.DAL.Models
{
    public class Shopper
    {
        public int ShopperId { get; set; }
        public string? ShopperName { get; set; }
        public List<ShoppingList> ShoppingList { get; set; }

    }
}
