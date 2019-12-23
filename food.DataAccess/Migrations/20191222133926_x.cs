using Microsoft.EntityFrameworkCore.Migrations;

namespace food.DataAccess.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_MenuItem_MenuItemID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "Transactionid",
                table: "OrderHeader",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "MenuItemID",
                table: "OrderDetails",
                newName: "MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_MenuItemID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_MenuItem_MenuItemId",
                table: "OrderDetails",
                column: "MenuItemId",
                principalTable: "MenuItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_MenuItem_MenuItemId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "OrderHeader",
                newName: "Transactionid");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "OrderDetails",
                newName: "MenuItemID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_MenuItemId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_MenuItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_MenuItem_MenuItemID",
                table: "OrderDetails",
                column: "MenuItemID",
                principalTable: "MenuItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
