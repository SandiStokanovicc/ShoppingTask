using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TactaShoppingTask.DAL.Data;
using TactaShoppingTask.DAL.Interfaces;
using TactaShoppingTask.DAL.Models;

namespace TactaShoppingTask.DAL.Services
{
    public class ShoppingListRepository : IShoppingListRepository
    {
        private readonly DataContext context;

        public ShoppingListRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task AddToShoppingList(ShoppingList list)
        {
            await context.ShoppingLists.AddAsync(list);
            await context.SaveChangesAsync();
        }

        public async Task<ShoppingList> FindShoppingListRecord(int ItemId, int ShopperId)
        {
            ShoppingList shoppingList = await context.ShoppingLists.
               Where(a => a.ShopperId == ShopperId && a.ItemId == ItemId).
               FirstOrDefaultAsync();

            return shoppingList;
        }

        public async Task<ShoppingList> RemoveItemFromShoppingList(ShoppingList listItem)
        {
            

            context.ShoppingLists.Remove(listItem);
            await context.SaveChangesAsync();
            return listItem;
        }
    }
}
