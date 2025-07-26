using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class SeedDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "AddUser", "CreatedDate", "LK_SpecialtiesID", "Name", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 26, 10, 42, 40, 306, DateTimeKind.Utc).AddTicks(905), 1, "Dr. khaled Abdullah", true, null },
                    { 2, 2, new DateTime(2025, 7, 26, 10, 42, 40, 306, DateTimeKind.Utc).AddTicks(907), 2, "Dr.Lana khaled", true, null }
                });

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 13, 42, 40, 306, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "LK_Specialtie",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 13, 42, 40, 306, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 10, 42, 40, 306, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 10, 42, 40, 306, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 10, 42, 40, 306, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 13, 42, 40, 306, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 13, 42, 40, 306, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 13, 42, 40, 306, DateTimeKind.Local).AddTicks(1045));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2);

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
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 8, 8, 49, 617, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 26, 8, 8, 49, 617, DateTimeKind.Utc).AddTicks(512));

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
    }
}
