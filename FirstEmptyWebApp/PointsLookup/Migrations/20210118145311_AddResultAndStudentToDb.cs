using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsLookup.Migrations
{
    public partial class AddResultAndStudentToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Student_StudentCMND",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentCMND",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BiologicalScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CMND_Student",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ChemiscalScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EnglishScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LiteratureScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MathScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhysicalScores",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentCMND",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "IdentNumber",
                table: "Students",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "CMND",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "CMND");

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MathScores = table.Column<double>(type: "float", nullable: false),
                    EnglishScores = table.Column<double>(type: "float", nullable: false),
                    LiteratureScores = table.Column<double>(type: "float", nullable: false),
                    ChemiscalScores = table.Column<double>(type: "float", nullable: false),
                    PhysicalScores = table.Column<double>(type: "float", nullable: false),
                    BiologicalScores = table.Column<double>(type: "float", nullable: false),
                    CMND_Student = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentCMND = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Students_StudentCMND",
                        column: x => x.StudentCMND,
                        principalTable: "Students",
                        principalColumn: "CMND",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentCMND",
                table: "Results",
                column: "StudentCMND");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CMND",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "IdentNumber");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "BiologicalScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CMND_Student",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ChemiscalScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EnglishScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LiteratureScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MathScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PhysicalScores",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "StudentCMND",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    CMND = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.CMND);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCMND",
                table: "Students",
                column: "StudentCMND");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Student_StudentCMND",
                table: "Students",
                column: "StudentCMND",
                principalTable: "Student",
                principalColumn: "CMND",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
