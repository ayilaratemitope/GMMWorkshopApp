using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMMWorkshopApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStoredRepairTotals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPartsCost",
                table: "Repairs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPartsCost",
                table: "Repairs",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
