using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductGroupMapUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("272c7181-48a5-47a9-8361-480a32402670"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8950c4db-1d17-4d66-aee5-9196fc18294a"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9683eca8-85c5-4cd8-9ef3-e5be523dc6c4"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9ce81d4d-e424-4a21-b9f5-4cd1f7664936"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ProductGroup",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("878c25b0-2908-4af7-8b15-5c1eca7db20d"), "user" },
                    { new Guid("7d1f8d91-882e-419d-982a-9a5a70ac5b1f"), "Manager" },
                    { new Guid("5f7e6c72-f290-463b-a229-b05aaa605bac"), "Admin" },
                    { new Guid("93ba203f-73b7-49e1-9008-d56bb9b08beb"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5f7e6c72-f290-463b-a229-b05aaa605bac"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7d1f8d91-882e-419d-982a-9a5a70ac5b1f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("878c25b0-2908-4af7-8b15-5c1eca7db20d"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("93ba203f-73b7-49e1-9008-d56bb9b08beb"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductGroup");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9ce81d4d-e424-4a21-b9f5-4cd1f7664936"), "user" },
                    { new Guid("9683eca8-85c5-4cd8-9ef3-e5be523dc6c4"), "Manager" },
                    { new Guid("272c7181-48a5-47a9-8361-480a32402670"), "Admin" },
                    { new Guid("8950c4db-1d17-4d66-aee5-9196fc18294a"), "Developer" }
                });
        }
    }
}
