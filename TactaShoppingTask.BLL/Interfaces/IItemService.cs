using TactaShoppingTask.DAL.DTOs.ItemDtos;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.BLL.Interfaces
{
    public interface IItemService
    {
        Task<List<GetItemDto>> GetAllItems();
    }
}
