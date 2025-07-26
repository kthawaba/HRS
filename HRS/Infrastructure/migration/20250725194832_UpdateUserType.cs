using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class UpdateUserType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_lK_UserType_lK_UserTypeId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_lK_UserTypeId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "lK_UserTypeId",
                table: "User",
                newName: "UserTypeId");

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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Mobile", "Name", "Status", "UserName", "UserTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 25, 19, 48, 32, 231, DateTimeKind.Utc).AddTicks(371), "0507319204", "System Admin", true, "admin", 1 },
                    { 2, new DateTime(2025, 7, 25, 19, 48, 32, 231, DateTimeKind.Utc).AddTicks(376), "0551234567", "Doctor Ali", true, "draliali", 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "User",
                newName: "lK_UserTypeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_lK_UserTypeId",
                table: "User",
                column: "lK_UserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_lK_UserType_lK_UserTypeId",
                table: "User",
                column: "lK_UserTypeId",
                principalTable: "lK_UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
