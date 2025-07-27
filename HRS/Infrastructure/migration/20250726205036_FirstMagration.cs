using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRS.Infrastructure.migration
{
    /// <inheritdoc />
    public partial class FirstMagration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lk_specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpecialtyName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SpecialtyCode = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lK_UserType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LK_SpecialtiesID = table.Column<int>(type: "INTEGER", nullable: false),
                    AddUser = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Getdate()"),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doctor_lk_specialties_LK_SpecialtiesID",
                        column: x => x.LK_SpecialtiesID,
                        principalTable: "lk_specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientID = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    AddUser = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DaysWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DayOfWeekNO = table.Column<int>(type: "INTEGER", nullable: false),
                    DayOfWeekName = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddUser = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaysWork_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "Mobile", "Name", "Status", "UserName", "UserTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9066), "0507319204", "System Admin", true, "admin", 1 },
                    { 2, new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9069), "0551234567", "Doctor Ali", true, "Doctor", 2 },
                    { 3, new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9071), "0500206391", "khaled", true, "Patient", 3 }
                });

            migrationBuilder.InsertData(
                table: "lK_UserType",
                columns: new[] { "Id", "CreatedDate", "Status", "UserTypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9043), true, "Admin" },
                    { 2, new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9044), true, "Doctor" },
                    { 3, new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(9045), true, "Patient" }
                });

            migrationBuilder.InsertData(
                table: "lk_specialties",
                columns: new[] { "Id", "CreatedDate", "Description", "SpecialtyCode", "SpecialtyName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(8890), "Heart and cardiovascular specialist", "CARD", "Cardiology", true },
                    { 2, new DateTime(2025, 7, 26, 23, 50, 35, 584, DateTimeKind.Local).AddTicks(8907), "Brain and nervous system specialist", "NEUR", "Neurology", true }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "AddUser", "CreatedDate", "LK_SpecialtiesID", "Name", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9091), 1, "Dr. khaled Abdullah", true, null },
                    { 2, 2, new DateTime(2025, 7, 26, 20, 50, 35, 584, DateTimeKind.Utc).AddTicks(9093), 2, "Dr.Lana khaled", true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientID",
                table: "Appointments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DaysWork_DoctorId",
                table: "DaysWork",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_LK_SpecialtiesID",
                table: "Doctor",
                column: "LK_SpecialtiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_lk_specialties_SpecialtyName",
                table: "lk_specialties",
                column: "SpecialtyName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "DaysWork");

            migrationBuilder.DropTable(
                name: "lK_UserType");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "lk_specialties");
        }
    }
}
