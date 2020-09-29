using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Data.Migrations
{
    public partial class AddedAnswerCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnswerCard",
                columns: new[] { "AnswerCardId", "DeckId", "Description", "PointValue" },
                values: new object[,]
                {
                    { 1, 1, "Apple Pie", 1 },
                    { 21, 3, "Maleficent", 3 },
                    { 22, 3, "Cruella de Vil", 3 },
                    { 23, 3, "Hades", 3 },
                    { 24, 3, "Dr.Facilier", 3 },
                    { 25, 3, "The Evil Queen", 3 },
                    { 26, 4, "An outbreak of smallpox", 4 },
                    { 20, 2, "Workplace meetings", 2 },
                    { 27, 4, "Famine", 4 },
                    { 29, 4, "The Bubonic Plague", 4 },
                    { 30, 4, "The 'Rona", 4 },
                    { 31, 5, "Ripping into a man's chest and pulling out his still-beating heart", 5 },
                    { 32, 5, "Entering a breakout room to find Beatrice patiently waiting for you", 5 },
                    { 33, 5, "Having a demon-possesed being crawl toward you down a flight of stairs", 5 },
                    { 34, 5, "Sacrificing your soul to a witch in exchange for their blood", 5 },
                    { 28, 4, "Dysentery", 4 },
                    { 19, 2, "Finding out your co-worker stole your stapler", 2 },
                    { 18, 2, "Writing up to-do lists", 2 },
                    { 17, 2, "Making the printer work", 2 },
                    { 2, 1, "Nothing", 1 },
                    { 3, 1, "Blueberries", 1 },
                    { 4, 1, "Death by bees", 1 },
                    { 5, 1, "Me time", 1 },
                    { 6, 1, "Neil Patrick Harris", 1 },
                    { 7, 1, "Power", 1 },
                    { 8, 1, "Active Listening", 1 },
                    { 9, 1, "College", 1 },
                    { 10, 1, "Moral Ambiguity", 1 },
                    { 11, 1, "Buddy, the goat, eating cans", 1 },
                    { 12, 1, "Living in a trashcan", 1 },
                    { 13, 1, "The miracle of childbirth", 1 },
                    { 14, 1, "Frolicking", 1 },
                    { 15, 1, "A private island caretaker", 1 },
                    { 16, 2, "Asking your boss for a raise", 2 },
                    { 35, 5, "Performing a seance during the witching hour", 5 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27749f8e-16d2-4303-a0cb-8bfd477b4ea9", "AQAAAAEAACcQAAAAEF6Bou5RynwMLywIH+yXjQJBupbyhsLpPoXuYozeQ1Mhn4L7gMsORKYXGU7Qriv7eA==", "fbb95ff2-99ab-43f4-9f81-4d2d8ac4bfbd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AnswerCard",
                keyColumn: "AnswerCardId",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc31f34-7535-40b6-a725-6288e56a155c", "AQAAAAEAACcQAAAAECh5+i57I8CEP3n8DdeTqRq+s5nQpO6xRH2HKQGkGSKSxP614PXi/DqIfGSKh9NYAw==", "4e4e4005-ffe8-4f4a-91e0-91683d32a93d" });
        }
    }
}
