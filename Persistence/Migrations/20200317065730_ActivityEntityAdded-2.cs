using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Activities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Activities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
