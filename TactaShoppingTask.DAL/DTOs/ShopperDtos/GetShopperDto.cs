using TactaShoppingTask.DAL.DTOs.ItemDtos;

namespace TactaShoppingTask.DAL.DTOs.ShopperDtos
{
    public class GetShopperDto
    {
        public int ShopperId { get; set; }
        public string? ShopperName { get; set; }
        public List<GetItemDto> Items { get; set; }
    }
}
