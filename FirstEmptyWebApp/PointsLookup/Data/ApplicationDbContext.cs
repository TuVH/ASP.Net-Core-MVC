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

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id=1,
                    IdentNumber ="732001",
                    Name="Nguyễn Quốc Hải",
                    DateOfBirth= new DateTime(2001,09,13),
                    MathScores=9,
                    LiteratureScores=7,
                    EnglishScores =7.3,
                    BiologicalScores=8,
                    PhysicalScores = 6.3,
                    ChemiscalScores = 4
                },
                new Student
                {
                    Id=2,
                    IdentNumber = "732002",
                    Name = "Lê Thanh Nhàn",
                    DateOfBirth = new DateTime(2001, 05, 05),
                    MathScores = 8,
                    LiteratureScores = 6,
                    EnglishScores = 9,
                    BiologicalScores = 4,
                    PhysicalScores = 5.5,
                    ChemiscalScores = 6
                },
                new Student
                {
                    Id=3,
                    IdentNumber = "732003",
                    Name = "Vũ Hoàng Tú",
                    DateOfBirth = new DateTime(2001, 05, 05),
                    MathScores = 8,
                    LiteratureScores = 6,
                    EnglishScores = 9,
                    BiologicalScores = 4,
                    PhysicalScores = 5.5,
                    ChemiscalScores = 6
                }
            );
        }
    }
}
