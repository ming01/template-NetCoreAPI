using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductGroupMapProductsv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
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
                name: "CreateBy",
                table: "Product");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalSchema: "auth",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateBy",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_UserId",
                table: "Product",
                column: "UserId",
                principalSchema: "auth",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
