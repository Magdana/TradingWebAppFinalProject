using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbersLists_Customers_CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbersLists_CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PhoneNumbersLists");

            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "DiscountAmount",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManufacturingDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RealizationPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ShelfLife",
                table: "Products",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumbersListId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumbersListId",
                table: "Customers",
                column: "PhoneNumbersListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PhoneNumbersLists_PhoneNumbersListId",
                table: "Customers",
                column: "PhoneNumbersListId",
                principalTable: "PhoneNumbersLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PhoneNumbersLists_PhoneNumbersListId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PhoneNumbersListId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ManufacturingDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RealizationPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShelfLife",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhoneNumbersListId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PhoneNumbersLists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbersLists_CustomerId",
                table: "PhoneNumbersLists",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbersLists_Customers_CustomerId",
                table: "PhoneNumbersLists",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
