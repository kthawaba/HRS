using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class SeedUserTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_users_UserId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_lk_specialties_LK_SpecialtiesID",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_users_UserId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_users_lK_UserType_lK_UserTypeId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserName",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lk_specialties",
                table: "lk_specialties");

            migrationBuilder.DropIndex(
                name: "IX_lk_specialties_SpecialtyName",
                table: "lk_specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "lk_specialties",
                newName: "LK_Specialtie");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_users_lK_UserTypeId",
                table: "User",
                newName: "IX_User_lK_UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_UserId",
                table: "Appointments",
                newName: "IX_Appointments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointments",
                newName: "IX_Appointments_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_DoctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Patient",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "lK_UserType",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Doctor",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DaysWork",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LK_Specialtie",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Appointments",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "Getdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LK_Specialtie",
                table: "LK_Specialtie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "lK_UserType",
                columns: new[] { "Id", "CreatedDate", "Status", "UserTypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 25, 20, 51, 25, 1, DateTimeKind.Local).AddTicks(8907), true, "Admin" },
                    { 2, new DateTime(2025, 7, 25, 20, 51, 25, 1, DateTimeKind.Local).AddTicks(8930), true, "Doctor" },
                    { 3, new DateTime(2025, 7, 25, 20, 51, 25, 1, DateTimeKind.Local).AddTicks(8932), true, "Patient" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patient_PatientID",
                table: "Appointments",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_User_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_LK_Specialtie_LK_SpecialtiesID",
                table: "Doctor",
                column: "LK_SpecialtiesID",
                principalTable: "LK_Specialtie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_User_UserId",
                table: "Doctor",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_lK_UserType_lK_UserTypeId",
                table: "User",
                column: "lK_UserTypeId",
                principalTable: "lK_UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctor_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patient_PatientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_User_UserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_LK_Specialtie_LK_SpecialtiesID",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_User_UserId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_User_lK_UserType_lK_UserTypeId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LK_Specialtie",
                table: "LK_Specialtie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lK_UserType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "LK_Specialtie",
                newName: "lk_specialties");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_User_lK_UserTypeId",
                table: "users",
                newName: "IX_users_lK_UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_UserId",
                table: "Appointment",
                newName: "IX_Appointment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientID",
                table: "Appointment",
                newName: "IX_Appointment_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointment",
                newName: "IX_Appointment_DoctorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Patient",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "lK_UserType",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Doctor",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DaysWork",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "users",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "lk_specialties",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Appointment",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "Getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lk_specialties",
                table: "lk_specialties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_users_UserName",
                table: "users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_lk_specialties_SpecialtyName",
                table: "lk_specialties",
                column: "SpecialtyName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientID",
                table: "Appointment",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_users_UserId",
                table: "Appointment",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_lk_specialties_LK_SpecialtiesID",
                table: "Doctor",
                column: "LK_SpecialtiesID",
                principalTable: "lk_specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_users_UserId",
                table: "Doctor",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_lK_UserType_lK_UserTypeId",
                table: "users",
                column: "lK_UserTypeId",
                principalTable: "lK_UserType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
