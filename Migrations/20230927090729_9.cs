using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelationshipTypeId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RelationshipTypeId",
                table: "Customers",
                column: "RelationshipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_RelationshipTypes_RelationshipTypeId",
                table: "Customers",
                column: "RelationshipTypeId",
                principalTable: "RelationshipTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_RelationshipTypes_RelationshipTypeId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RelationshipTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RelationshipTypeId",
                table: "Customers");
        }
    }
}
