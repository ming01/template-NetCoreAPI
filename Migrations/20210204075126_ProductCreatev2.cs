using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreAPI.Migrations
{
    public partial class ProductCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("db7ee947-73c5-4b57-8213-f2a7dce1a89e"), "user" },
                    { new Guid("a7e22de1-80d8-46ae-a505-2c33cd8c3348"), "Manager" },
                    { new Guid("a394e397-0fa9-453c-a07a-18bbb936d3d5"), "Admin" },
                    { new Guid("98059bec-8742-42cf-819c-51523961f2ec"), "Developer" }
                });
        }
    }
}
