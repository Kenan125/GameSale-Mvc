using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameSale_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewDate",
                table: "Reviews",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "GameSales",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "GameSaleDetails",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Games",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SystemRequirements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SystemRequirements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Publishers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Images",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GameSales",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GameSaleDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1724), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1738), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1739), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1740), false });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1740), false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1899), false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1906), false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1908), false });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1910), false });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2016), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2019), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2020), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2020), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2021), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2022), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2023), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2024), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2025), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2026), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2027), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2028), false });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(2028), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1989), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1990), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1991), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1992), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1992), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1993), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1994), false });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 27, 47, 777, DateTimeKind.Local).AddTicks(1995), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SystemRequirements");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SystemRequirements");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GameSales");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GameSaleDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Reviews",
                newName: "ReviewDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "GameSales",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "GameSaleDetails",
                newName: "PurchaseDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Games",
                newName: "ReleaseDate");

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
        }
    }
}
