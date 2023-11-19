using AutoMapper;
using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.DTOs.ShoppingListDtos;
using TactaShoppingTask.DAL.Models;
using TactaShoppingTask.BLL.Interfaces;
using TactaShoppingTask.DAL.Interfaces;

namespace TactaShoppingTask.BLL.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly IShoppingListRepository shoppingListRepository;
        private readonly IItemRepository itemRepository;
        private readonly IShopperRepository shopperRepository;
        private readonly IMapper mapper;
        private int decreaseQuantityValue = -1;
        private int increaseQuantityValue = 1;

        public ShoppingListService(IShoppingListRepository shoppingListRepository,
            IItemRepository itemRepository,
            IShopperRepository shopperRepository,
            IMapper mapper)
        {
            this.shoppingListRepository = shoppingListRepository;
            this.itemRepository = itemRepository;
            this.shopperRepository = shopperRepository;
            this.mapper = mapper;
        }

        public async Task<GetShopperDto> AddToShoppingList(AddToListDto newListItem)
        {

            var shopper = await shopperRepository.GetShopperById(newListItem.ShopperId);
            var item = await itemRepository.GetItemById(newListItem.ItemId);

            if (item.ItemQuantity <= 0)
            {
                throw new Exception("Not Enough items in stock.");
            }

            var listItem = await shoppingListRepository.FindShoppingListRecord(newListItem.ItemId, newListItem.ShopperId);

            if (listItem != null)
            {
                throw new Exception("Item already added.");
            }

            ShoppingList shoppingList = new ShoppingList
            {
                Item = item,
                Shopper = shopper
            };

            await shoppingListRepository.AddToShoppingList(shoppingList);

            await decreaseQuantity(newListItem.ItemId);

            return mapper.Map<GetShopperDto>(shopper);
        }

        public async Task<GetShopperDto> GetShoppingList(int id)
        {
            var shopper = await shopperRepository.GetShopperById(id);

            if (shopper == null)
            {
                throw new Exception("Shopper does not exist");
            }

            return mapper.Map<GetShopperDto>(shopper);

        }

        public async Task<GetShopperDto> RemoveItemFromShoppingList(int itemId, int shopperId)
        {
            ShoppingList listItem = await shoppingListRepository.FindShoppingListRecord(itemId, shopperId);

            await shoppingListRepository.RemoveItemFromShoppingList(listItem);

            await increaseQuantity(itemId);

            return await GetShoppingList(shopperId);
        }



        private async Task decreaseQuantity(int itemId)
        {
            await itemRepository.UpdateItemQuantity(itemId, decreaseQuantityValue);
        }

        private async Task increaseQuantity(int itemId)
        {
            await itemRepository.UpdateItemQuantity(itemId, increaseQuantityValue);
        }
    }
}
