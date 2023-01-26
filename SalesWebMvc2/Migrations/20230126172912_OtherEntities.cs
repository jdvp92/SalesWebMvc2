using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc2.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Namer",
                table: "Seller",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "Namer");
        }
    }
}
