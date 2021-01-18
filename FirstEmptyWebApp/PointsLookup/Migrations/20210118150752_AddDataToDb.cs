using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsLookup.Migrations
{
    public partial class AddDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "Id", "BiologicalScores", "CMND_Student", "ChemiscalScores", "EnglishScores", "IdentNumber", "LiteratureScores", "MathScores", "PhysicalScores", "StudentCMND", "Year" },
                values: new object[,]
                {
                    { 1, 8.5, "079201005182", 9.0, 8.5, "732001", 4.5, 8.0, 5.5, null, 2018 },
                    { 2, 4.0, "079201005182", 4.0, 4.5, "742005", 4.5, 8.5, 5.5, null, 2019 },
                    { 3, 7.0, "079201005183", 7.0, 5.0, "732006", 3.0, 7.5, 5.0, null, 2018 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "CMND", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { "079201005182", new DateTime(2001, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vũ Nhật Tú" },
                    { "079201005183", new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngô Thanh Long" },
                    { "079201005184", new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoàng Kim Tiến" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "CMND",
                keyValue: "079201005182");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "CMND",
                keyValue: "079201005183");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "CMND",
                keyValue: "079201005184");
        }
    }
}
