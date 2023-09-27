using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_DiscountOrNots_IsDiscountedId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "DiscountOrNots");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_IsDiscountedId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "IsDiscountedId",
                table: "OrderItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscounted",
                table: "OrderItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDiscounted",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "IsDiscountedId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DiscountOrNots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDiscounted = table.Column<bool>(type: "bit", nullable: false),
                    IsNotDisqounted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountOrNots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_IsDiscountedId",
                table: "OrderItems",
                column: "IsDiscountedId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_DiscountOrNots_IsDiscountedId",
                table: "OrderItems",
                column: "IsDiscountedId",
                principalTable: "DiscountOrNots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
