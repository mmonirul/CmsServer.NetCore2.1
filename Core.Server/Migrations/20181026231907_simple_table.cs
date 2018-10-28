using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Server.Migrations
{
    public partial class simple_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DefaultImageUrl = table.Column<string>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: true),
                    Memory = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionOptions",
                columns: table => new
                {
                    SubscriptionOptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionOptions", x => x.SubscriptionOptionId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                    table.ForeignKey(
                        name: "FK_Colors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "DefaultImageUrl", "Description", "Memory", "Name", "Price", "SubscriptionId", "Tag" },
                values: new object[,]
                {
                    { 1, "Apple", "Mobile", "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/grid/apple-iphone-xs-grid-258x310-gold.png", "Oled-skärm och 12 MP-kamera", 64, "iPhone Xs", 599m, 1, "Nyhet" },
                    { 2, "Apple", "Mobile", "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-x/grid/produktbild-grid-apple-iphone-x-silver.png", "En heltäckande upplevelse", 64, "iPhone Xs", 599m, 1, "Prissänkt" },
                    { 3, "Apple", "Mobile", "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs-max/grid/apple-iphone-xs-max-grid-258x310-gold.png", "Bästa kameran någonsin", 64, "iPhone Xs Max", 599m, 1, "Nyhet" },
                    { 4, "Samsung", "Mobile", "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/samsung/galaxy-note-9/mobilgrid/telenor-samsung-galaxzynote9black-2_344x414.png?quality=100&height=310", "Just nu: Gear IconX - hörlurar och trådlös laddare på köpet", 64, "Galaxy Note9", 599m, 1, "Kampanj" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionOptions",
                columns: new[] { "SubscriptionOptionId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, "Abonnemang 3GB", 299m },
                    { 2, null, "Abonnemang 4GB", 399m },
                    { 3, null, "Abonnemang 4GB", 499m }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ImageId", "Name", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Guld", 1, 0 },
                    { 2, 2, "Silver", 1, 0 },
                    { 3, 3, "Rymd grå", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "Caption", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, "Guld", 1, "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-gold-370x484.png" },
                    { 2, "Silver", 1, "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-silver-370x484.png" },
                    { 3, "Rymd grå", 1, "https://www.telenor.se/globalassets/mediabibliotek/produktbilder/mobiler/apple/iphone-xs/produktsida/telenor-iphone-xs-spacegray-370x484.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ProductId",
                table: "Colors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SubscriptionOptions");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
