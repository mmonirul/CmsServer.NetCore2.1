using Microsoft.EntityFrameworkCore;

namespace Core.Server.Dal.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "iPhone Xs",
                    Brand = "Apple",
                    Category = "Mobile",
                    Price = 599,
                    Memory = 64,
                    Description = "Oled-skärm [I got 3 more pics & color options]",
                    SubscriptionId = 1,
                    Tag = "Nyhet",
                    DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/grid/apple-iphone-xs-grid-258x310-gold.png"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "iPhone Xs",
                    Brand = "Apple",
                    Category = "Mobile",
                    Price = 599,
                    Memory = 64,
                    Description = "Oled-skärm och 12 MP-kamera",
                    SubscriptionId = 1,
                    Tag = "Prissänkt",
                    DefaultImageUrl = "https://adockastorage.blob.core.windows.net/146-cloudfiles-public/sverek/apple-iphone-x-silver.png",
                },
                new Product
                {
                    ProductId = 3,
                    Name = "iPhone Xs Max",
                    Brand = "Apple",
                    Category = "Mobile",
                    Price = 599,
                    Memory = 64,
                    Description = "Oled-skärm och 12 MP-kamera",
                    DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs-max/grid/apple-iphone-xs-max-grid-258x310-gold.png",
                    SubscriptionId = 1,
                    Tag = "Nyhet"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Galaxy Note9",
                    Brand = "Samsung",
                    Category = "Mobile",
                    Price = 599,
                    Memory = 64,
                    Description = "Oled-skärm och 12 MP-kamera",
                    DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/samsung/galaxy-note-9/mobilgrid/telenor-samsung-galaxzynote9black-2_344x414.png?quality=100&height=310",
                    SubscriptionId = 1,
                    Tag = "Kampanj"
                }

            );

            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 1, ProductId = 1, Name = "Guld", ImageId = 1 },
                new Color { ColorId = 2, ProductId = 1, Name = "Silver", ImageId = 2 },
                new Color { ColorId = 3, ProductId = 1, Name = "Rymd grå", ImageId = 3 }
            );
            modelBuilder.Entity<Image>().HasData(
                new Image { ImageId = 1, ProductId = 1, Caption = "Guld", Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-gold-370x484.png" },
                new Image { ImageId = 2, ProductId = 1, Caption = "Silver", Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-silver-370x484.png" },
                new Image { ImageId = 3, ProductId = 1, Caption = "Rymd grå", Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-spacegray-370x484.png" }
            );
            modelBuilder.Entity<SubscriptionOption>().HasData(
                new SubscriptionOption { SubscriptionOptionId = 1, Name = "Abonnemang 3GB", Price = 299 },
                new SubscriptionOption { SubscriptionOptionId = 2, Name = "Abonnemang 4GB", Price = 399 },
                new SubscriptionOption { SubscriptionOptionId = 3, Name = "Abonnemang 4GB", Price = 499 }
            );

        }
    }

}
