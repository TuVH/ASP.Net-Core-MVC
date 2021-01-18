using Microsoft.EntityFrameworkCore;
using PointsLookup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsLookup.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Result> Results { get; set; }

        public DbSet<Student> Students { get; set; }

        //Data Seeding (Thêm data vào trước khi chạy chương trình)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    CMND="079201005182",
                    Name="Vũ Nhật Tú",
                    DateOfBirth= new DateTime(2001,09,13)
                },
                new Student
                {
                    CMND = "079201005183",
                    Name = "Ngô Thanh Long",
                    DateOfBirth = new DateTime(2001, 09, 14)
                },
                new Student
                {
                    CMND = "079201005184",
                    Name = "Hoàng Kim Tiến",
                    DateOfBirth = new DateTime(2001, 09, 15)
                }
            );
            modelBuilder.Entity<Result>().HasData(
                new Result
                {
                    Id =1,
                    CMND_Student= "079201005182",
                    IdentNumber= "732001",
                    MathScores = 8,
                    BiologicalScores =8.5,
                    ChemiscalScores = 9,
                    PhysicalScores = 5.5,
                    EnglishScores = 8.5,
                    LiteratureScores = 4.5,
                    Year = 2018

                },
                new Result
                {
                    Id = 2,
                    CMND_Student = "079201005182",
                    IdentNumber = "742005",
                    MathScores = 8.5,
                    BiologicalScores = 4,
                    ChemiscalScores = 4,
                    PhysicalScores = 5.5,
                    EnglishScores = 4.5,
                    LiteratureScores = 4.5,
                    Year = 2019
                },
                new Result
                {
                    Id = 3,
                    CMND_Student = "079201005183",
                    IdentNumber = "732006",
                    MathScores = 7.5,
                    BiologicalScores = 7,
                    ChemiscalScores = 7,
                    PhysicalScores = 5,
                    EnglishScores = 5,
                    LiteratureScores = 3,
                    Year = 2018
                }
            );
        }
    }
}
