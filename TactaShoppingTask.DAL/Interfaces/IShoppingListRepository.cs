using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.DAL.Interfaces
{
    public interface IShoppingListRepository
    {
        Task AddToShoppingList(ShoppingList list);
        Task<ShoppingList> RemoveItemFromShoppingList(ShoppingList listItem);
        Task<ShoppingList> FindShoppingListRecord(int ItemId, int ShopperId);
    }
}
