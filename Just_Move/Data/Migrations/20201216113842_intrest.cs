using Microsoft.EntityFrameworkCore.Migrations;

namespace Just_Move.Data.Migrations
{
    public partial class intrest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IntrestDomain",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntrestDomain",
                table: "AspNetUsers");
        }
    }
}
