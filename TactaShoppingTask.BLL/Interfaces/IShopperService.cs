using TactaShoppingTask.DAL.DTOs.ShopperDtos;


namespace TactaShoppingTask.BLL.Interfaces
{
    public interface IShopperService
    {
        Task<List<ShopperWithoutItemsDto>> GetAllShoppers();
    }
}
