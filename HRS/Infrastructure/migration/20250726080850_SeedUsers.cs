using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 11, 8, 49, 617, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 11, 8, 49, 617, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 8, 8, 49, 617, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2025, 7, 26, 8, 8, 49, 617, DateTimeKind.Utc).AddTicks(510), "Doctor" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Mobile", "Name", "Status", "UserName", "UserTypeId" },
                values: new object[] { 3, new DateTime(2025, 7, 26, 8, 8, 49, 617, DateTimeKind.Utc).AddTicks(512), "0500206391", "khaled", true, "Patient", 3 });

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 11, 8, 49, 617, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 11, 8, 49, 617, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 11, 8, 49, 617, DateTimeKind.Local).AddTicks(671));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 22, 48, 32, 231, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 22, 48, 32, 231, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 19, 48, 32, 231, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserName" },
                values: new object[] { new DateTime(2025, 7, 25, 19, 48, 32, 231, DateTimeKind.Utc).AddTicks(376), "draliali" });

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 22, 48, 32, 231, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 22, 48, 32, 231, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 25, 22, 48, 32, 231, DateTimeKind.Local).AddTicks(553));
        }
    }
}
