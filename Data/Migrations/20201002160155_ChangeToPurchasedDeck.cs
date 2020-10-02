using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Data.Migrations
{
    public partial class ChangeToPurchasedDeck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedDeck_AspNetUsers_UserId1",
                table: "PurchasedDeck");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedDeck_UserId1",
                table: "PurchasedDeck");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "PurchasedDeck");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PurchasedDeck",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c088745a-6f0e-42b8-b4dc-629f2ec17f89", "AQAAAAEAACcQAAAAEL6tLd1sbJH/QeZ+ktcvIfnixoNXwXoBm0phr7ENQblj4nlP3B8gluX6SiRJ6hIPcg==", "1241b7a6-8421-442b-bbe2-9f1c373adf2b" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedDeck_UserId",
                table: "PurchasedDeck",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedDeck_AspNetUsers_UserId",
                table: "PurchasedDeck",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchasedDeck_AspNetUsers_UserId",
                table: "PurchasedDeck");

            migrationBuilder.DropIndex(
                name: "IX_PurchasedDeck_UserId",
                table: "PurchasedDeck");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PurchasedDeck",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "PurchasedDeck",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf2acd5-b969-41f3-b089-10e44afc209b", "AQAAAAEAACcQAAAAEBtRd7xn/oG26/pmEoKhAu1IDDsSalc+OKbc0OwVIDBbYg2K96Metyf5DgBzbuFh5Q==", "13e4780b-d9af-40f1-9d11-8c5ae7fb2970" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedDeck_UserId1",
                table: "PurchasedDeck",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasedDeck_AspNetUsers_UserId1",
                table: "PurchasedDeck",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
