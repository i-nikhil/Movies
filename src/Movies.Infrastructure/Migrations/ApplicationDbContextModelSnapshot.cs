﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Infrastructure;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1831),
                            Name = 0,
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1832)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1833),
                            Name = 1,
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834),
                            Name = 2,
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1835)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836),
                            Name = 3,
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836)
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
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1774),
                            ReleaseYear = 2012,
                            RuntimeMinutes = 143,
                            Title = "Avengers",
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1786)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1788),
                            ReleaseYear = 2003,
                            RuntimeMinutes = 143,
                            Title = "Pirates of the Caribbean",
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1789)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790),
                            ReleaseYear = 2022,
                            RuntimeMinutes = 148,
                            Title = "Spider-Man: No way home",
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828),
                            ReleaseYear = 2021,
                            RuntimeMinutes = 148,
                            Title = "The Matrix Resurrections",
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1829),
                            ReleaseYear = 2013,
                            RuntimeMinutes = 112,
                            Title = "The Conjuring",
                            UpdatedAt = new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1830)
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
