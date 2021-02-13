using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_User_UserId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_UserId",
                table: "ProductGroup");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("75c29cc5-19b7-431f-a3cf-cfcd633a7c7c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8dbb984d-9d34-4b73-b422-705a18735c2f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c159799d-a8de-401c-8fb7-519c9566d589"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("febce959-c25f-45d7-9c8f-78a64d35911b"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductGroup");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bf281875-dc2c-4d65-a5ef-33b14a5a1a7d"), "user" },
                    { new Guid("29d476cf-f16c-4fae-a93f-51d895d076dd"), "Manager" },
                    { new Guid("6ea92df9-4345-46ad-beba-c4d95a5aef7e"), "Admin" },
                    { new Guid("0645122a-9949-4393-9660-85cd8c492c43"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0645122a-9949-4393-9660-85cd8c492c43"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("29d476cf-f16c-4fae-a93f-51d895d076dd"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6ea92df9-4345-46ad-beba-c4d95a5aef7e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bf281875-dc2c-4d65-a5ef-33b14a5a1a7d"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ProductGroup",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c159799d-a8de-401c-8fb7-519c9566d589"), "user" },
                    { new Guid("8dbb984d-9d34-4b73-b422-705a18735c2f"), "Manager" },
                    { new Guid("75c29cc5-19b7-431f-a3cf-cfcd633a7c7c"), "Admin" },
                    { new Guid("febce959-c25f-45d7-9c8f-78a64d35911b"), "Developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroup_UserId",
                table: "ProductGroup",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroup_User_UserId",
                table: "ProductGroup",
                column: "UserId",
                principalSchema: "auth",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
