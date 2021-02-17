using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class StockCardCreatev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7b9690a4-a907-4321-875d-01c4f0f91c2e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b220b8df-d39a-4ce0-b7b4-1d53f83f30da"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e2872515-8b2b-4043-99b6-174ce1183dbb"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f48aa52d-680d-430d-9835-668c29cc205a"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "StockCard",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d4839dc5-06eb-4dc6-8a42-1e6f8b9ec28a"), "user" },
                    { new Guid("7642508a-ac04-4d33-8ede-f1615358607b"), "Manager" },
                    { new Guid("af5865c3-95c7-4f8e-bba7-faaf041d3403"), "Admin" },
                    { new Guid("d8e2b851-f263-42e9-a89d-b178ba11cc09"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7642508a-ac04-4d33-8ede-f1615358607b"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("af5865c3-95c7-4f8e-bba7-faaf041d3403"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d4839dc5-06eb-4dc6-8a42-1e6f8b9ec28a"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d8e2b851-f263-42e9-a89d-b178ba11cc09"));

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "StockCard");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f48aa52d-680d-430d-9835-668c29cc205a"), "user" },
                    { new Guid("b220b8df-d39a-4ce0-b7b4-1d53f83f30da"), "Manager" },
                    { new Guid("7b9690a4-a907-4321-875d-01c4f0f91c2e"), "Admin" },
                    { new Guid("e2872515-8b2b-4043-99b6-174ce1183dbb"), "Developer" }
                });
        }
    }
}
