using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class updateIDCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
