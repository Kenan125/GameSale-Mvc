using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameSale_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Categories_CategoryId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_Publishers_PublisherId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSale_Customers_CustomerId",
                table: "GameSale");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaleDetails_GameSale_GameSaleId",
                table: "GameSaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaleDetails_Game_GameId",
                table: "GameSaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Game_GameId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemRequirements_Game_GameId",
                table: "SystemRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameSale",
                table: "GameSale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Game");

            migrationBuilder.RenameTable(
                name: "GameSale",
                newName: "GameSales");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_GameSale_CustomerId",
                table: "GameSales",
                newName: "IX_GameSales_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_PublisherId",
                table: "Games",
                newName: "IX_Games_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_CategoryId",
                table: "Games",
                newName: "IX_Games_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameSales",
                table: "GameSales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 19, 48, 3, 800, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 19, 48, 3, 800, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 19, 48, 3, 800, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 8, 19, 48, 3, 800, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "GameId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "/images/witcher3.jpg", "witcher3" },
                    { 2, 2, "/images/gtav.jpg", "gtav" },
                    { 3, 3, "/images/cyberpunk2077.jpg", "cyberpunk2077" },
                    { 4, 4, "/images/rdr2.jpg", "rdr2" },
                    { 5, 5, "/images/civ6.jpg", "civ6" },
                    { 6, 6, "/images/sims4.jpg", "sims4" },
                    { 7, 7, "/images/darksouls3.jpg", "darksouls3" },
                    { 8, 8, "/images/minecraft.jpg", "minecraft" },
                    { 9, 9, "/images/fortnite.jpg", "fortnite" },
                    { 10, 10, "/images/stardewvalley.jpg", "stardewvalley" },
                    { 11, 7, "/images/darksouls3Caus.jpg", "darksouls3Caus" },
                    { 12, 4, "/images/rdr2Caus.jpg", "rdr2Caus" },
                    { 13, 9, "/images/fortniteCaus.jpg", "fortniteCaus" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_GameId",
                table: "Images",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaleDetails_GameSales_GameSaleId",
                table: "GameSaleDetails",
                column: "GameSaleId",
                principalTable: "GameSales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaleDetails_Games_GameId",
                table: "GameSaleDetails",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSales_Customers_CustomerId",
                table: "GameSales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemRequirements_Games_GameId",
                table: "SystemRequirements",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaleDetails_GameSales_GameSaleId",
                table: "GameSaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaleDetails_Games_GameId",
                table: "GameSaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSales_Customers_CustomerId",
                table: "GameSales");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemRequirements_Games_GameId",
                table: "SystemRequirements");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameSales",
                table: "GameSales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "GameSales",
                newName: "GameSale");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameIndex(
                name: "IX_GameSales_CustomerId",
                table: "GameSale",
                newName: "IX_GameSale_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PublisherId",
                table: "Game",
                newName: "IX_Game_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CategoryId",
                table: "Game",
                newName: "IX_Game_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "/images/gamename.jpg");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameSale",
                table: "GameSale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "Id");

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
                column: "ImgUrl",
                value: "witcher3.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUrl",
                value: "gtav.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: "cyberpunk2077.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUrl",
                value: "rdr2.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUrl",
                value: "civ6.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgUrl",
                value: "sims4.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgUrl",
                value: "darksouls3.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgUrl",
                value: "minecraft.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgUrl",
                value: "fortnite.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImgUrl",
                value: "stardewvalley.jpg");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Categories_CategoryId",
                table: "Game",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Publishers_PublisherId",
                table: "Game",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSale_Customers_CustomerId",
                table: "GameSale",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaleDetails_GameSale_GameSaleId",
                table: "GameSaleDetails",
                column: "GameSaleId",
                principalTable: "GameSale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaleDetails_Game_GameId",
                table: "GameSaleDetails",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Game_GameId",
                table: "Reviews",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemRequirements_Game_GameId",
                table: "SystemRequirements",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
