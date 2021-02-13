using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductGroupMapProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Bulks",
                columns: table => new
                {
                    BulkId = table.Column<int>(nullable: false),
                    BulkName = table.Column<string>(maxLength: 20, nullable: true),
                    BulkCode = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulks", x => x.BulkId);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("161dfd1e-318c-4d3f-9329-c9c4433208e3"), "user" },
                    { new Guid("7a2b7890-84e5-4f0f-992d-caf8728541f9"), "Manager" },
                    { new Guid("dca000d8-b404-41e1-827b-c236dc1c6c9d"), "Admin" },
                    { new Guid("6d601a5e-15f4-4123-94ac-bb3af0f642bd"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bulks");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("161dfd1e-318c-4d3f-9329-c9c4433208e3"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6d601a5e-15f4-4123-94ac-bb3af0f642bd"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7a2b7890-84e5-4f0f-992d-caf8728541f9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("dca000d8-b404-41e1-827b-c236dc1c6c9d"));

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
    }
}
