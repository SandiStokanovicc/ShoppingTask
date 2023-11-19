using TactaShoppingTask.BLL.Interfaces;
using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.Interfaces;

namespace TactaShoppingTask.BLL.Services
{
    public class ShopperService : IShopperService
    {
        private readonly IShopperRepository shopperRepository;

        public ShopperService(IShopperRepository shopperRepository)
        {
            this.shopperRepository = shopperRepository;
        }

        public async Task<List<ShopperWithoutItemsDto>> GetAllShoppers()
        {
            return await shopperRepository.GetAllShoppers();

        }
    }
}
