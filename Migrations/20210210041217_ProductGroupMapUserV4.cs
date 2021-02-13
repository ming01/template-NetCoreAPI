using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductGroupMapUserV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
