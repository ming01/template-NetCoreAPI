using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductCreatev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("15293506-6a8d-4d25-9ac3-82da07c92f0e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bc9d7968-a6dc-4a0e-836b-6350ca761cd8"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fc2e661a-009b-4329-8d7c-9b1b0e497936"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fece1ffc-fdca-4f04-a5d8-265173d19b04"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("42b60f8f-b21a-442f-94d0-cdcd0024e720"), "user" },
                    { new Guid("c2d4a853-5ff1-4bdc-8c27-ef6b6e7c55f0"), "Manager" },
                    { new Guid("e10d750b-6ac9-4518-a959-41afb864f7ff"), "Admin" },
                    { new Guid("35b4d7bb-442b-4dcc-9a29-9eed405fbcb9"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("35b4d7bb-442b-4dcc-9a29-9eed405fbcb9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("42b60f8f-b21a-442f-94d0-cdcd0024e720"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c2d4a853-5ff1-4bdc-8c27-ef6b6e7c55f0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e10d750b-6ac9-4518-a959-41afb864f7ff"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bc9d7968-a6dc-4a0e-836b-6350ca761cd8"), "user" },
                    { new Guid("fc2e661a-009b-4329-8d7c-9b1b0e497936"), "Manager" },
                    { new Guid("15293506-6a8d-4d25-9ac3-82da07c92f0e"), "Admin" },
                    { new Guid("fece1ffc-fdca-4f04-a5d8-265173d19b04"), "Developer" }
                });
        }
    }
}
