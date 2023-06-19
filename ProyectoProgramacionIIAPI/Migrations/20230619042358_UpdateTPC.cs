using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoProgramacionIIAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2023, 6, 13, 21, 24, 58, 281, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2023, 6, 13, 21, 24, 58, 281, DateTimeKind.Local).AddTicks(776));
        }
    }
}
