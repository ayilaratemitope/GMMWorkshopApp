using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMMWorkshopApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPartCategoryEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartType",
                table: "Parts");

            migrationBuilder.AddColumn<int>(
                name: "PartCategory",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartCategory",
                table: "Parts");

            migrationBuilder.AddColumn<string>(
                name: "PartType",
                table: "Parts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
