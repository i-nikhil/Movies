﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Infrastructure;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220904153447_changes")]
    partial class changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movies.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("DeletedAt IS NULL");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5128),
                            Name = "Comedy",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5129)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5131),
                            Name = "Drama",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5132)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5134),
                            Name = "Thriller",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5135)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5137),
                            Name = "Horror",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5138)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5139),
                            DeletedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5141),
                            Name = "Retro",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5140)
                        });
                });

            modelBuilder.Entity("Movies.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<int>("RuntimeMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5091),
                            ReleaseYear = 2012,
                            RuntimeMinutes = 143,
                            Title = "Avengers",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5111)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5114),
                            ReleaseYear = 2003,
                            RuntimeMinutes = 143,
                            Title = "Pirates of the Caribbean",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5115)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5117),
                            ReleaseYear = 2022,
                            RuntimeMinutes = 148,
                            Title = "Spider-Man: No way home",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5118)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5120),
                            ReleaseYear = 2021,
                            RuntimeMinutes = 148,
                            Title = "The Matrix Resurrections",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5121)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5124),
                            ReleaseYear = 2013,
                            RuntimeMinutes = 112,
                            Title = "The Conjuring",
                            UpdatedAt = new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5125)
                        });
                });

            modelBuilder.Entity("Movies.Domain.Entities.MovieGenreMapping", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenreMappings");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreId = 2,
                            Id = 1
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 3,
                            Id = 2
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 1,
                            Id = 3
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 2,
                            Id = 4
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 3,
                            Id = 5
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 3,
                            Id = 6
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 2,
                            Id = 7
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 3,
                            Id = 8
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 3,
                            Id = 9
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 4,
                            Id = 10
                        });
                });

            modelBuilder.Entity("Movies.Domain.Entities.MovieGenreMapping", b =>
                {
                    b.HasOne("Movies.Domain.Entities.Genre", null)
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies.Domain.Entities.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Movies.Domain.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Movies.Domain.Entities.Movie", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}