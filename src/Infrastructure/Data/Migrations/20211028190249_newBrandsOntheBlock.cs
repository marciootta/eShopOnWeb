using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    public partial class newBrandsOntheBlock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into CatalogBrands(Id, Brand, Notes) values ( 6, 'Atari', 'This is new')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from CatalogBrands where Brand = 'Atari'");

        }
    }
}
