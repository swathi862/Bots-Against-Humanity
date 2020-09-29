using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Data.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Deck",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Score", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "000000001", 0, "6dc31f34-7535-40b6-a725-6288e56a155c", "swathi@email.com", true, "Swathi", "Mukkamala", false, null, "SWATHI@EMAIL.COM", "SWATHI86", "AQAAAAEAACcQAAAAECh5+i57I8CEP3n8DdeTqRq+s5nQpO6xRH2HKQGkGSKSxP614PXi/DqIfGSKh9NYAw==", null, false, 0, "4e4e4005-ffe8-4f4a-91e0-91683d32a93d", false, "Swathi86" });

            migrationBuilder.InsertData(
                table: "Deck",
                columns: new[] { "DeckId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Starter Deck", 0 },
                    { 2, "Just Office Things", 15 },
                    { 3, "Disney Villains", 45 },
                    { 4, "Illnesses and Ailments", 95 },
                    { 5, "Quintessential Horror Movie Scenes", 155 }
                });

            migrationBuilder.InsertData(
                table: "QuestionCard",
                columns: new[] { "QuestionCardId", "Description" },
                values: new object[,]
                {
                    { 15, "What's that sound?" },
                    { 16, "What's a girl's best friend?" },
                    { 17, "_________. That's how I want to die." },
                    { 18, "I'm sorry, Professor, but I couldn't complete my homework because of __________." },
                    { 21, "I'm thinking about getting a lower-back tattoo of _________." },
                    { 20, "Breaking News: ____________." },
                    { 14, "I've got 99 problems but ___________ ain't one." },
                    { 22, "Love is patient. Love is kind. Love is __________." },
                    { 23, "What ended my last relationship?" },
                    { 19, "Sorry I'm late! I was ____________." },
                    { 13, "West Virginia runs on __________." },
                    { 10, "What are all those chipmunks singing about?" },
                    { 11, "___________: kid-tested, mother-approved" },
                    { 24, "Before I run for president, I must destroy all evidence of my involvement with __________." },
                    { 9, "I'm not like the rest of you. I'm too rich and busy for _________." },
                    { 8, "I learned the hard way that you can't cheer up a grieving friend with ___________." },
                    { 7, "This is the prime of my life. I'm young, hot, and full of ___________." },
                    { 6, "The class field trip was completely ruined by _______." },
                    { 5, "What did I give up for Lent?" },
                    { 4, "My gym teacher got fired for adding _______ to the obstacle course." },
                    { 3, "What did The Rock eat for dinner?" },
                    { 2, "What really brings out the child in me?" },
                    { 1, "This is your captain speaking. Fasten your seatbelts and prepare for" },
                    { 12, "Science will never explain ___________." },
                    { 25, "____________. Awesome in theory, kind of a mess in practice." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000000001");

            migrationBuilder.DeleteData(
                table: "Deck",
                keyColumn: "DeckId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Deck",
                keyColumn: "DeckId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Deck",
                keyColumn: "DeckId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Deck",
                keyColumn: "DeckId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Deck",
                keyColumn: "DeckId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestionCard",
                keyColumn: "QuestionCardId",
                keyValue: 25);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Deck",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
