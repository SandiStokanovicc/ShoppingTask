using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.DTOs.ShoppingListDtos;

namespace TactaShoppingTask.BLL.Interfaces
{
    public interface IShoppingListService
    {
        Task<GetShopperDto> AddToShoppingList(AddToListDto newListItem);
        Task<GetShopperDto> GetShoppingList(int id);
        Task<GetShopperDto> RemoveItemFromShoppingList(int itemId, int shopperId);
    }
}
