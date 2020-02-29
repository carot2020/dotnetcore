using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab09.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 2, 59, 706, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 2, 59, 707, DateTimeKind.Local).AddTicks(6564));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 0, 25, 477, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 0, 25, 479, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 0, 25, 479, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 2, 28, 19, 0, 25, 479, DateTimeKind.Local).AddTicks(2311));
        }
    }
}
