using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class MapUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Product",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e75bde23-1a3b-4d9b-a1e8-540a9b0764d5"), "user" },
                    { new Guid("cb73161e-34ab-4a84-8f0f-0e15298790f0"), "Manager" },
                    { new Guid("de79dace-c455-4619-948b-a223d97525ba"), "Admin" },
                    { new Guid("8fb27cf9-d1c7-4524-95d7-961af9a569c4"), "Developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalSchema: "auth",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                table: "Product");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8fb27cf9-d1c7-4524-95d7-961af9a569c4"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cb73161e-34ab-4a84-8f0f-0e15298790f0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("de79dace-c455-4619-948b-a223d97525ba"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e75bde23-1a3b-4d9b-a1e8-540a9b0764d5"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Product");

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
    }
}
