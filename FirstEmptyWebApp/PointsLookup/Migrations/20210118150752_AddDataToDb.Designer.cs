﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PointsLookup.Data;

namespace PointsLookup.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210118150752_AddDataToDb")]
    partial class AddDataToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PointsLookup.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("BiologicalScores")
                        .HasColumnType("float");

                    b.Property<string>("CMND_Student")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ChemiscalScores")
                        .HasColumnType("float");

                    b.Property<double>("EnglishScores")
                        .HasColumnType("float");

                    b.Property<string>("IdentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LiteratureScores")
                        .HasColumnType("float");

                    b.Property<double>("MathScores")
                        .HasColumnType("float");

                    b.Property<double>("PhysicalScores")
                        .HasColumnType("float");

                    b.Property<string>("StudentCMND")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentCMND");

                    b.ToTable("Results");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiologicalScores = 8.5,
                            CMND_Student = "079201005182",
                            ChemiscalScores = 9.0,
                            EnglishScores = 8.5,
                            IdentNumber = "732001",
                            LiteratureScores = 4.5,
                            MathScores = 8.0,
                            PhysicalScores = 5.5,
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            BiologicalScores = 4.0,
                            CMND_Student = "079201005182",
                            ChemiscalScores = 4.0,
                            EnglishScores = 4.5,
                            IdentNumber = "742005",
                            LiteratureScores = 4.5,
                            MathScores = 8.5,
                            PhysicalScores = 5.5,
                            Year = 2019
                        },
                        new
                        {
                            Id = 3,
                            BiologicalScores = 7.0,
                            CMND_Student = "079201005183",
                            ChemiscalScores = 7.0,
                            EnglishScores = 5.0,
                            IdentNumber = "732006",
                            LiteratureScores = 3.0,
                            MathScores = 7.5,
                            PhysicalScores = 5.0,
                            Year = 2018
                        });
                });

            modelBuilder.Entity("PointsLookup.Models.Student", b =>
                {
                    b.Property<string>("CMND")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CMND");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            CMND = "079201005182",
                            DateOfBirth = new DateTime(2001, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vũ Nhật Tú"
                        },
                        new
                        {
                            CMND = "079201005183",
                            DateOfBirth = new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ngô Thanh Long"
                        },
                        new
                        {
                            CMND = "079201005184",
                            DateOfBirth = new DateTime(2001, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hoàng Kim Tiến"
                        });
                });

            modelBuilder.Entity("PointsLookup.Models.Result", b =>
                {
                    b.HasOne("PointsLookup.Models.Student", "Student")
                        .WithMany("Result")
                        .HasForeignKey("StudentCMND");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("PointsLookup.Models.Student", b =>
                {
                    b.Navigation("Result");
                });
#pragma warning restore 612, 618
        }
    }
}