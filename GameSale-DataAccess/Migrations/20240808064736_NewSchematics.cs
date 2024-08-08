using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameSale_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewSchematics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Game");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 9, 47, 35, 264, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 9, 47, 35, 264, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 9, 47, 35, 264, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 9, 47, 35, 264, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublisherId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublisherId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublisherId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublisherId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublisherId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublisherId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublisherId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublisherId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublisherId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublisherId",
                value: 8);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CD Projekt" },
                    { 2, "Rockstar Games" },
                    { 3, "2K Games" },
                    { 4, "Electronic Arts" },
                    { 5, "Bandai Namco Entertainment" },
                    { 6, "Mojang" },
                    { 7, "Epic Games" },
                    { 8, "ConcernedApe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_PublisherId",
                table: "Game",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Publishers_PublisherId",
                table: "Game",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Publishers_PublisherId",
                table: "Game");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Game_PublisherId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Game");

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 7, 23, 11, 10, 81, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 7, 23, 11, 10, 81, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 7, 23, 11, 10, 81, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 7, 23, 11, 10, 81, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 1,
                column: "Publisher",
                value: "CD Projekt");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 2,
                column: "Publisher",
                value: "Rockstar Games");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 3,
                column: "Publisher",
                value: "CD Projekt");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 4,
                column: "Publisher",
                value: "Rockstar Games");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 5,
                column: "Publisher",
                value: "2K Games");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 6,
                column: "Publisher",
                value: "Electronic Arts");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 7,
                column: "Publisher",
                value: "Bandai Namco Entertainment");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 8,
                column: "Publisher",
                value: "Mojang");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 9,
                column: "Publisher",
                value: "Epic Games");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 10,
                column: "Publisher",
                value: "ConcernedApe");
        }
    }
}
