using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductGroupMapUserv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CreateBy",
                table: "ProductGroup");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ProductGroup",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("69a253f9-6c28-4b7b-8c3e-0bf8a8351a80"), "user" },
                    { new Guid("c2e2b109-e634-44dc-a441-18a4e8a9836f"), "Manager" },
                    { new Guid("c6e58118-253a-4e52-8826-11b3fc2e48f1"), "Admin" },
                    { new Guid("b2409373-cfb1-476c-b288-eec758c37c03"), "Developer" }
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
                keyValue: new Guid("69a253f9-6c28-4b7b-8c3e-0bf8a8351a80"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b2409373-cfb1-476c-b288-eec758c37c03"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c2e2b109-e634-44dc-a441-18a4e8a9836f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c6e58118-253a-4e52-8826-11b3fc2e48f1"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ProductGroup",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateBy",
                table: "ProductGroup",
                type: "uniqueidentifier",
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
    }
}
