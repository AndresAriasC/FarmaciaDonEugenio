using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoProgramacionIIAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhone = table.Column<int>(type: "int", nullable: false),
                    ClientAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUTCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderPhone = table.Column<int>(type: "int", nullable: false),
                    ProviderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2023, 6, 18, 19, 39, 9, 50, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ClientAdress", "ClientDate", "ClientEmail", "ClientLastName", "ClientName", "ClientPhone", "ProductId" },
                values: new object[] { 1, "De donde venden chicha", new DateTime(2023, 6, 18, 19, 39, 9, 50, DateTimeKind.Local).AddTicks(6977), "AgaDia@gmail.com", "Díaz", "Agapito", 77194813, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "ProviderId" },
                values: new object[] { new DateTime(2023, 6, 18, 19, 39, 9, 50, DateTimeKind.Local).AddTicks(6839), 1 });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ProviderId", "ProviderDate", "ProviderEmail", "ProviderName", "ProviderPhone", "RUTCode" },
                values: new object[] { 1, new DateTime(2023, 6, 18, 19, 39, 9, 50, DateTimeKind.Local).AddTicks(6964), "labramos@gmail.com.ni", "Laboratorios Ramos", 18002020, "222" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId",
                table: "Products",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ProductId",
                table: "Clients",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Providers_ProviderId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProviderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Products");

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
