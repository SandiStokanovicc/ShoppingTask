using TactaShoppingTask.DAL.DTOs.ItemDtos;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.DAL.Interfaces
{
    public interface IItemRepository
    {
        Task<List<GetItemDto>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task<Item> UpdateItemQuantity(int ItemId, int quantityChange);
    }
}
