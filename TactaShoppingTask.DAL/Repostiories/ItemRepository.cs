using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TactaShoppingTask.DAL.Data;
using TactaShoppingTask.DAL.DTOs.ItemDtos;
using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.Interfaces;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.DAL.Services
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public ItemRepository(DataContext context, 
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<GetItemDto>> GetAllItems()
        {
            List<Item> dbItems = await context.Items.ToListAsync();

            return dbItems.Select(a => mapper.Map<GetItemDto>(a))
                .ToList();
        }

        public async Task<Item> GetItemById(int id)
        {
            Item item = await context.Items.
                Where(a => a.ItemId == id).
                FirstOrDefaultAsync();

            return item;
        }

        public async Task<Item> UpdateItemQuantity(int ItemId, int quantityChange)
        {
            var item = await GetItemById(ItemId);

            item.ItemQuantity = item.ItemQuantity + quantityChange;
            await context.SaveChangesAsync();

            return await GetItemById(ItemId);
        }
    }
}
