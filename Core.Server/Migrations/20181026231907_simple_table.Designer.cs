﻿// <auto-generated />
using System;
using Core.Server.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Server.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20181026231907_simple_table")]
    partial class simple_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Server.Dal.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImageId");

                    b.Property<string>("Name");

                    b.Property<int>("ProductId");

                    b.Property<int>("Url");

                    b.HasKey("ColorId");

                    b.HasIndex("ProductId");

                    b.ToTable("Colors");

                    b.HasData(
                        new { ColorId = 1, ImageId = 1, Name = "Guld", ProductId = 1, Url = 0 },
                        new { ColorId = 2, ImageId = 2, Name = "Silver", ProductId = 1, Url = 0 },
                        new { ColorId = 3, ImageId = 3, Name = "Rymd grå", ProductId = 1, Url = 0 }
                    );
                });

            modelBuilder.Entity("Core.Server.Dal.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption");

                    b.Property<int>("ProductId");

                    b.Property<string>("Url");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new { ImageId = 1, Caption = "Guld", ProductId = 1, Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-gold-370x484.png" },
                        new { ImageId = 2, Caption = "Silver", ProductId = 1, Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-silver-370x484.png" },
                        new { ImageId = 3, Caption = "Rymd grå", ProductId = 1, Url = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-spacegray-370x484.png" }
                    );
                });

            modelBuilder.Entity("Core.Server.Dal.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Category");

                    b.Property<string>("DefaultImageUrl");

                    b.Property<string>("Description");

                    b.Property<int?>("Memory");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SubscriptionId");

                    b.Property<string>("Tag");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new { ProductId = 1, Brand = "Apple", Category = "Mobile", DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/grid/apple-iphone-xs-grid-258x310-gold.png", Description = "Oled-skärm och 12 MP-kamera", Memory = 64, Name = "iPhone Xs", Price = 599m, SubscriptionId = 1, Tag = "Nyhet" },
                        new { ProductId = 2, Brand = "Apple", Category = "Mobile", DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-x/grid/produktbild-grid-apple-iphone-x-silver.png", Description = "En heltäckande upplevelse", Memory = 64, Name = "iPhone Xs", Price = 599m, SubscriptionId = 1, Tag = "Prissänkt" },
                        new { ProductId = 3, Brand = "Apple", Category = "Mobile", DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs-max/grid/apple-iphone-xs-max-grid-258x310-gold.png", Description = "Bästa kameran någonsin", Memory = 64, Name = "iPhone Xs Max", Price = 599m, SubscriptionId = 1, Tag = "Nyhet" },
                        new { ProductId = 4, Brand = "Samsung", Category = "Mobile", DefaultImageUrl = "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/samsung/galaxy-note-9/mobilgrid/telenor-samsung-galaxzynote9black-2_344x414.png?quality=100&height=310", Description = "Just nu: Gear IconX - hörlurar och trådlös laddare på köpet", Memory = 64, Name = "Galaxy Note9", Price = 599m, SubscriptionId = 1, Tag = "Kampanj" }
                    );
                });

            modelBuilder.Entity("Core.Server.Dal.Models.SubscriptionOption", b =>
                {
                    b.Property<int>("SubscriptionOptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SubscriptionOptionId");

                    b.ToTable("SubscriptionOptions");

                    b.HasData(
                        new { SubscriptionOptionId = 1, Name = "Abonnemang 3GB", Price = 299m },
                        new { SubscriptionOptionId = 2, Name = "Abonnemang 4GB", Price = 399m },
                        new { SubscriptionOptionId = 3, Name = "Abonnemang 4GB", Price = 499m }
                    );
                });

            modelBuilder.Entity("Core.Server.Dal.Models.Color", b =>
                {
                    b.HasOne("Core.Server.Dal.Models.Product")
                        .WithMany("Colors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Server.Dal.Models.Image", b =>
                {
                    b.HasOne("Core.Server.Dal.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
