using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class ResetCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carts_CartID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CartID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Item1",
                table: "Orders",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Item2",
                table: "Orders",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Item3",
                table: "Orders",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item3",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemOne = table.Column<int>(type: "int", nullable: false),
                    ItemOneGet = table.Column<bool>(type: "bit", nullable: false),
                    ItemThree = table.Column<int>(type: "int", nullable: false),
                    ItemThreeGet = table.Column<bool>(type: "bit", nullable: false),
                    ItemTwo = table.Column<int>(type: "int", nullable: false),
                    ItemTwoGet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartID",
                table: "Orders",
                column: "CartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carts_CartID",
                table: "Orders",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
