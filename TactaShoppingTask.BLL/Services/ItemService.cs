using TactaShoppingTask.BLL.Interfaces;
using TactaShoppingTask.DAL.DTOs.ItemDtos;
using TactaShoppingTask.DAL.Interfaces;

namespace TactaShoppingTask.BLL.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public async Task<List<GetItemDto>> GetAllItems()
        {
            return await itemRepository.GetAllItems(); 

        }
    }
}
