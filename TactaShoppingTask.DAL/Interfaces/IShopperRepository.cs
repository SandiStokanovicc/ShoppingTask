using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.DAL.Interfaces
{
    public interface IShopperRepository
    {
        Task<List<ShopperWithoutItemsDto>> GetAllShoppers();
        Task<Shopper> GetShopperById(int id);
    }
}
