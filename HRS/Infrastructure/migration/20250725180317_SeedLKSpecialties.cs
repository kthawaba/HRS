using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class SeedLKSpecialties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 3, 17, 150, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 3, 17, 150, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 3, 17, 150, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 3, 17, 150, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 3, 17, 150, DateTimeKind.Local).AddTicks(1378));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 1, 40, 813, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 1, 40, 813, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 21, 1, 40, 813, DateTimeKind.Local).AddTicks(8839));
        }
    }
}
