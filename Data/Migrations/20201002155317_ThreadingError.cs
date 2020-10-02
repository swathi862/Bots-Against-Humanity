using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Data.Migrations
{
    public partial class ThreadingError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf2acd5-b969-41f3-b089-10e44afc209b", "AQAAAAEAACcQAAAAEBtRd7xn/oG26/pmEoKhAu1IDDsSalc+OKbc0OwVIDBbYg2K96Metyf5DgBzbuFh5Q==", "13e4780b-d9af-40f1-9d11-8c5ae7fb2970" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d387d3a-5d3e-46ab-8455-6c35b4de60d0", "AQAAAAEAACcQAAAAEOJWtGOZFwAU+kNHmONZRZqWeQ0fiS5LjSwZEboSILCIoNo7NkqDtLzewzMIFglIJA==", "124e28e2-de23-489c-b431-28e100b64ec8" });
        }
    }
}
