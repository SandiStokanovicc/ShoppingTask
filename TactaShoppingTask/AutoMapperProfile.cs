using AutoMapper;
using TactaShoppingTask.DAL.DTOs.ItemDtos;
using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Shopper, GetShopperDto>()
                .ForMember(dto => dto.Items, c => c.MapFrom(c => c.ShoppingList.Select(sl => sl.Item)));

            CreateMap<Shopper, ShopperWithoutItemsDto>();
            CreateMap<Item, GetItemDto>();
        }
    }
}
