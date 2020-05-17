using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Restructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItemId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StoreId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "Orders",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Store",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemId",
                table: "Orders",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemId",
                table: "Orders",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
