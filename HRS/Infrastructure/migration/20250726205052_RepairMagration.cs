using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class RepairMagration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 52, 106, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 52, 106, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 52, 106, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 52, 106, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 52, 106, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 52, 106, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 52, 106, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 52, 106, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "lk_specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 52, 106, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "lk_specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 52, 106, DateTimeKind.Local).AddTicks(5725));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "lk_specialties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "lk_specialties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(8907));
        }
    }
}
