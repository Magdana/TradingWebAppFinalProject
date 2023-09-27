using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PhoneNumbersLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneTypeId",
                table: "PhoneNumbersLists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbersLists_CustomerId",
                table: "PhoneNumbersLists",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbersLists_PhoneTypeId",
                table: "PhoneNumbersLists",
                column: "PhoneTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbersLists_Customers_CustomerId",
                table: "PhoneNumbersLists",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbersLists_PhoneTypes_PhoneTypeId",
                table: "PhoneNumbersLists",
                column: "PhoneTypeId",
                principalTable: "PhoneTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbersLists_Customers_CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbersLists_PhoneTypes_PhoneTypeId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbersLists_CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbersLists_PhoneTypeId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropColumn(
                name: "PhoneTypeId",
                table: "PhoneNumbersLists");
        }
    }
}
