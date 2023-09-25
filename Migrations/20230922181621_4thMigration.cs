using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _4thMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContainingCountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ContainingCountryId",
                table: "Cities",
                column: "ContainingCountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_ContainingCountryId",
                table: "Cities",
                column: "ContainingCountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_ContainingCountryId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ContainingCountryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ContainingCountryId",
                table: "Cities");
        }
    }
}
