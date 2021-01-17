using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsLookup.Migrations
{
    public partial class AddStudentToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MathScores = table.Column<double>(type: "float", nullable: false),
                    EnglishScores = table.Column<double>(type: "float", nullable: false),
                    LiteratureScores = table.Column<double>(type: "float", nullable: false),
                    ChemiscalScores = table.Column<double>(type: "float", nullable: false),
                    PhysicalScores = table.Column<double>(type: "float", nullable: false),
                    BiologicalScores = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
