using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class StockCardCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "StockCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Remark = table.Column<string>(maxLength: 1000, nullable: true),
                    Add = table.Column<int>(nullable: false),
                    Del = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockCard_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockCard_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f48aa52d-680d-430d-9835-668c29cc205a"), "user" },
                    { new Guid("b220b8df-d39a-4ce0-b7b4-1d53f83f30da"), "Manager" },
                    { new Guid("7b9690a4-a907-4321-875d-01c4f0f91c2e"), "Admin" },
                    { new Guid("e2872515-8b2b-4043-99b6-174ce1183dbb"), "Developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockCard_ProductId",
                table: "StockCard",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockCard_UserId",
                table: "StockCard",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockCard");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7b9690a4-a907-4321-875d-01c4f0f91c2e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b220b8df-d39a-4ce0-b7b4-1d53f83f30da"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e2872515-8b2b-4043-99b6-174ce1183dbb"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f48aa52d-680d-430d-9835-668c29cc205a"));

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
    }
}
