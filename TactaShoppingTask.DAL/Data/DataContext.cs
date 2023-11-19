using Microsoft.EntityFrameworkCore;
using TactaShoppingTask.DAL.Models;


namespace TactaShoppingTask.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ShoppingList>()
                .HasKey(sl => new { sl.ShopperId, sl.ItemId });

            modelBuilder.Entity<Item>().HasData(
                new Item { ItemId = 1, ItemName = "Bread", ItemQuantity = 3 },
                new Item { ItemId = 2, ItemName = "Milk", ItemQuantity = 3 },
                new Item { ItemId = 3, ItemName = "Eggs", ItemQuantity = 3 },
                new Item { ItemId = 4, ItemName = "Honey", ItemQuantity = 3 },
                new Item { ItemId = 5, ItemName = "Ketchup", ItemQuantity = 3 }
                );

            modelBuilder.Entity<Shopper>().HasData(
                new Shopper { ShopperId = 1, ShopperName = "Jim"},
                new Shopper { ShopperId = 2, ShopperName = "John" },
                new Shopper { ShopperId = 3, ShopperName = "Emma" },
                new Shopper { ShopperId = 4, ShopperName = "Andrea" },
                new Shopper { ShopperId = 5, ShopperName = "Martin" }
            );
        }


    }
}
