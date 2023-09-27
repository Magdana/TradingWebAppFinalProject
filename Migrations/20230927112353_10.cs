using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryPhoneNumber",
                table: "PhoneNumbersLists");

            migrationBuilder.DropColumn(
                name: "SecondPhoneNumber",
                table: "PhoneNumbersLists");

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "PhoneNumbersLists",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "PhoneNumbersLists");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "PhoneNumbersLists",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondPhoneNumber",
                table: "PhoneNumbersLists",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
