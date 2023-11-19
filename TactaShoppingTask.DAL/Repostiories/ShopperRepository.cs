using Microsoft.EntityFrameworkCore;
using AutoMapper;
using TactaShoppingTask.DAL.Data;
using TactaShoppingTask.DAL.DTOs.ShopperDtos;
using TactaShoppingTask.DAL.Models;
using TactaShoppingTask.DAL.Interfaces;

namespace TactaShoppingTask.DAL.Services
{

    public class ShopperRepository : IShopperRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public ShopperRepository(DataContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ShopperWithoutItemsDto>> GetAllShoppers()
        {
            List<Shopper> dbShoppers = await context.Shoppers.ToListAsync();

            return dbShoppers.Select(a => mapper.Map<ShopperWithoutItemsDto>(a))
                .ToList();
        }

        public async Task<Shopper> GetShopperById(int id)
        {
            Shopper shopper = await context.Shoppers.
                Include(s => s.ShoppingList).ThenInclude(i => i.Item).
                Where(a => a.ShopperId == id).
                FirstOrDefaultAsync();

            return shopper;
        }
    }
}
