using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VIPStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                   new Product
                   {
                       Name = "Naruto",
                       Description = " Action, Adventure, Humor",
                       Category = "Japan",
                       Price = 500
                   },
                    new Product
                    {
                        Name = "Onepiece",
                        Description = "Action, Adventure, Humor",
                        Category = "Japan",
                        Price = 475
                    },
                    new Product
                    {
                        Name = "Đấu La Đại Lục",
                        Description = " Action, Martial Arts, Fairy",
                        Category = "China",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Phàm Nhân Tu Tiên",
                        Description = "Action, Martial Arts, Fairy",
                        Category = "China",
                        Price = 375
                    },
                    new Product
                    {
                        Name = "Wonder Woman",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 425
                    },
                    new Product
                    {
                        Name = "Aquaman",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 475
                    }                  
                    );
                context.SaveChanges();
            }
        }
    }
}
