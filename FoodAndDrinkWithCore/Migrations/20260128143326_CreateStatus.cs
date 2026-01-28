using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAndDrinkWithCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "categories");
        }
    }
}
