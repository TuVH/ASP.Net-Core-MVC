using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsLookup.Migrations
{
    public partial class SeedStudentsToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BiologicalScores", "ChemiscalScores", "DateOfBirth", "EnglishScores", "IdentNumber", "LiteratureScores", "MathScores", "Name", "PhysicalScores" },
                values: new object[] { 1, 8.0, 4.0, new DateTime(2001, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2999999999999998, "732001", 7.0, 9.0, "Nguyễn Quốc Hải", 6.2999999999999998 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BiologicalScores", "ChemiscalScores", "DateOfBirth", "EnglishScores", "IdentNumber", "LiteratureScores", "MathScores", "Name", "PhysicalScores" },
                values: new object[] { 2, 4.0, 6.0, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, "732002", 6.0, 8.0, "Lê Thanh Nhàn", 5.5 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BiologicalScores", "ChemiscalScores", "DateOfBirth", "EnglishScores", "IdentNumber", "LiteratureScores", "MathScores", "Name", "PhysicalScores" },
                values: new object[] { 3, 4.0, 6.0, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, "732003", 6.0, 8.0, "Vũ Hoàng Tú", 5.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
