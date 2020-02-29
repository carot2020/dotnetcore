using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab08.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "524ecb29-d5c5-45dc-88c2-a2643e09a1ca", "a0407c1e-2d29-4f9b-b674-7c4b6088d5bb", "Visitor", "VISITOR" },
                    { "0f10165a-071f-4f21-8708-a3d560d6f68c", "ee2226ee-5bad-4465-a5b0-41033122e5a4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 20, 33, 470, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 20, 33, 471, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 20, 33, 471, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 20, 33, 471, DateTimeKind.Local).AddTicks(6729));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f10165a-071f-4f21-8708-a3d560d6f68c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524ecb29-d5c5-45dc-88c2-a2643e09a1ca");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 9, 44, 344, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 9, 44, 345, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 9, 44, 345, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 2, 29, 8, 9, 44, 345, DateTimeKind.Local).AddTicks(8547));
        }
    }
}
