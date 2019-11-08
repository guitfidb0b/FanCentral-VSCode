using Microsoft.EntityFrameworkCore.Migrations;

namespace FanCentral.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jersies = table.Column<bool>(nullable: false),
                    Men = table.Column<bool>(nullable: false),
                    Women = table.Column<bool>(nullable: false),
                    Kids = table.Column<bool>(nullable: false),
                    Shirts = table.Column<bool>(nullable: false),
                    Sweatshirts = table.Column<bool>(nullable: false),
                    Hats = table.Column<bool>(nullable: false),
                    Accessories = table.Column<bool>(nullable: false),
                    HomeAndOffice = table.Column<bool>(nullable: false),
                    Collectibles = table.Column<bool>(nullable: false),
                    Clearance = table.Column<bool>(nullable: false),
                    Salute = table.Column<bool>(nullable: false),
                    WearCollection = table.Column<bool>(nullable: false),
                    NFL100 = table.Column<bool>(nullable: false),
                    Minshew = table.Column<bool>(nullable: false),
                    Retired = table.Column<bool>(nullable: false),
                    Season25 = table.Column<bool>(nullable: false),
                    Brand = table.Column<bool>(nullable: false),
                    Sideline = table.Column<bool>(nullable: false),
                    Players = table.Column<bool>(nullable: false),
                    Custom = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
