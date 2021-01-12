using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VIPStore.Models;

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
                       Price = 500,
                       UrlImage = "Naruto.jpg"
                   },
                    new Product
                    {
                        Name = "Onepiece",
                        Description = "Action, Adventure, Humor",
                        Category = "Japan",
                        Price = 475,
                        UrlImage = "OnePiece.jpg"
                    },
                    new Product
                    {
                        Name = "Đấu La Đại Lục",
                        Description = " Action, Martial Arts, Fairy",
                        Category = "China",
                        Price = 400,
                        UrlImage = "Dldl.jpg"
                    },
                    new Product
                    {
                        Name = "Phàm Nhân Tu Tiên",
                        Description = "Action, Martial Arts, Fairy",
                        Category = "China",
                        Price = 375,
                        UrlImage = "Pntt.jpg"
                    },
                    new Product
                    {
                        Name = "Wonder Woman",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 425,
                        UrlImage = "WonderWoman.jpg"
                    },
                    new Product
                    {
                        Name = "Aquaman",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 475,
                        UrlImage = "Aquaman.jpg"
                    },
                    new Product
                    {
                        Name = "FairyTail",
                        Description = " Action, Adventure, Humor",
                        Category = "Japan",
                        Price = 480,
                        UrlImage = "FairyTail.jpg"
                    },
                    new Product
                    {
                        Name = "OnePunchMan",
                        Description = " Action, Adventure, Humor",
                        Category = "Japan",
                        Price = 500,
                        UrlImage = "OnePunchMan.jpg"
                    },
                    new Product
                    {
                        Name = "Avengers: Endgame",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 520,
                        UrlImage = "AvengersEndgame.jpg"
                    },
                    new Product
                    {
                        Name = "IronMan",
                        Description = "Action, Fiction",
                        Category = "USA",
                        Price = 485,
                        UrlImage = "IronMan.jpg"
                    },
                    new Product
                    {
                        Name = "ĐP thương khung",
                        Description = " Action, Martial Arts, Fairy",
                        Category = "China",
                        Price = 450,
                        UrlImage = "Dptk.jpg"
                    },
                    new Product
                    {
                        Name = "Sword art online ",
                        Description = " Action, Martial Arts, Fairy",
                        Category = "Japan",
                        Price = 495,
                        UrlImage = "SwordArtOnline.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
