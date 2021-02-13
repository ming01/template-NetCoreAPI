using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class StockCardCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("35bf555b-966c-4d98-965a-f21fc79f8a41"), "user" },
                    { new Guid("35ec0315-1e88-4601-b245-45d8b4063505"), "Manager" },
                    { new Guid("2cdf4657-8522-4e69-b249-9da5cf0d6c5c"), "Admin" },
                    { new Guid("2b8da4f9-e700-4514-a721-53a37ab44934"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2b8da4f9-e700-4514-a721-53a37ab44934"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2cdf4657-8522-4e69-b249-9da5cf0d6c5c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("35bf555b-966c-4d98-965a-f21fc79f8a41"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("35ec0315-1e88-4601-b245-45d8b4063505"));

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
    }
}
