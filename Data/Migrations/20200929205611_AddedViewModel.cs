using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Data.Migrations
{
    public partial class AddedViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d387d3a-5d3e-46ab-8455-6c35b4de60d0", "AQAAAAEAACcQAAAAEOJWtGOZFwAU+kNHmONZRZqWeQ0fiS5LjSwZEboSILCIoNo7NkqDtLzewzMIFglIJA==", "124e28e2-de23-489c-b431-28e100b64ec8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27749f8e-16d2-4303-a0cb-8bfd477b4ea9", "AQAAAAEAACcQAAAAEF6Bou5RynwMLywIH+yXjQJBupbyhsLpPoXuYozeQ1Mhn4L7gMsORKYXGU7Qriv7eA==", "fbb95ff2-99ab-43f4-9f81-4d2d8ac4bfbd" });
        }
    }
}
