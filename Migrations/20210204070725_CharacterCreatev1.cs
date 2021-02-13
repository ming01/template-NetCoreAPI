using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class CharacterCreatev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("099242f7-e500-415e-b96c-ed2989ca47cd"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("53b82fc7-eec3-4063-83af-6c70881c94b6"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("86a4d2bf-c3a3-4818-a477-60b751651f97"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b1997d82-7839-40e7-9ab3-a868812babdb"));

            migrationBuilder.DropColumn(
                name: "GropId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "ProductGroupId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("db7ee947-73c5-4b57-8213-f2a7dce1a89e"), "user" },
                    { new Guid("a7e22de1-80d8-46ae-a505-2c33cd8c3348"), "Manager" },
                    { new Guid("a394e397-0fa9-453c-a07a-18bbb936d3d5"), "Admin" },
                    { new Guid("98059bec-8742-42cf-819c-51523961f2ec"), "Developer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product",
                column: "ProductGroupId",
                principalTable: "ProductGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("98059bec-8742-42cf-819c-51523961f2ec"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a394e397-0fa9-453c-a07a-18bbb936d3d5"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a7e22de1-80d8-46ae-a505-2c33cd8c3348"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("db7ee947-73c5-4b57-8213-f2a7dce1a89e"));

            migrationBuilder.AlterColumn<int>(
                name: "ProductGroupId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GropId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("53b82fc7-eec3-4063-83af-6c70881c94b6"), "user" },
                    { new Guid("099242f7-e500-415e-b96c-ed2989ca47cd"), "Manager" },
                    { new Guid("86a4d2bf-c3a3-4818-a477-60b751651f97"), "Admin" },
                    { new Guid("b1997d82-7839-40e7-9ab3-a868812babdb"), "Developer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductGroup_ProductGroupId",
                table: "Product",
                column: "ProductGroupId",
                principalTable: "ProductGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
