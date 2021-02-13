using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class StockCardTypeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1fabaa84-fdcd-4b33-8911-2d01fd785ce7"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4bdd8fc5-6ad6-4578-8c3f-b707486ae6cb"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("80c9b1a2-a494-424a-afab-c52082ee6f33"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9a2f9174-a0a1-4753-b52b-11481ce6f806"));

            migrationBuilder.CreateTable(
                name: "StockCardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCardTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("985d3775-3f9c-4f5f-a51a-a24c4695e50c"), "user" },
                    { new Guid("65955427-e9a3-488b-a733-e7c48edc2e5e"), "Manager" },
                    { new Guid("1a9ac5c3-004f-47b0-b1bb-edfb0dfb69ca"), "Admin" },
                    { new Guid("ecd7720c-6316-4ad7-8c99-7a8b6c60b773"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockCardTypes");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1a9ac5c3-004f-47b0-b1bb-edfb0dfb69ca"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("65955427-e9a3-488b-a733-e7c48edc2e5e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("985d3775-3f9c-4f5f-a51a-a24c4695e50c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ecd7720c-6316-4ad7-8c99-7a8b6c60b773"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1fabaa84-fdcd-4b33-8911-2d01fd785ce7"), "user" },
                    { new Guid("9a2f9174-a0a1-4753-b52b-11481ce6f806"), "Manager" },
                    { new Guid("80c9b1a2-a494-424a-afab-c52082ee6f33"), "Admin" },
                    { new Guid("4bdd8fc5-6ad6-4578-8c3f-b707486ae6cb"), "Developer" }
                });
        }
    }
}
