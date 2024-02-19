﻿// <auto-generated />
using IRDb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IRDb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240219224113_NewInitial")]
    partial class NewInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IRDb.Models.MovieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MovieModels");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Director = "Frank Darabont",
                            Duration = 142,
                            Genre = "Drama",
                            Rating = 9.3000000000000007,
                            Title = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            Id = -2,
                            Director = "Francis Ford Coppola",
                            Duration = 175,
                            Genre = "Crime, Drama",
                            Rating = 9.1999999999999993,
                            Title = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            Id = -3,
                            Director = "Christopher Nolan",
                            Duration = 152,
                            Genre = "Action, Crime, Drama",
                            Rating = 9.0,
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            Id = -4,
                            Director = "Quentin Tarantino",
                            Duration = 154,
                            Genre = "Crime, Drama",
                            Rating = 8.9000000000000004,
                            Title = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = -5,
                            Director = "David Fincher",
                            Duration = 139,
                            Genre = "Drama",
                            Rating = 8.8000000000000007,
                            Title = "Fight Club",
                            Year = 1999
                        },
                        new
                        {
                            Id = -6,
                            Director = "Robert Zemeckis",
                            Duration = 142,
                            Genre = "Drama, Romance",
                            Rating = 8.8000000000000007,
                            Title = "Forrest Gump",
                            Year = 1994
                        },
                        new
                        {
                            Id = -7,
                            Director = "Christopher Nolan",
                            Duration = 148,
                            Genre = "Action, Adventure, Sci-Fi",
                            Rating = 8.6999999999999993,
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = -8,
                            Director = "Lana Wachowski, Lilly Wachowski",
                            Duration = 136,
                            Genre = "Action, Sci-Fi",
                            Rating = 8.6999999999999993,
                            Title = "The Matrix",
                            Year = 1999
                        },
                        new
                        {
                            Id = -9,
                            Director = "Christopher Nolan",
                            Duration = 169,
                            Genre = "Adventure, Drama, Sci-Fi",
                            Rating = 8.5999999999999996,
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            Id = -10,
                            Director = "Peter Jackson",
                            Duration = 178,
                            Genre = "Adventure, Drama, Fantasy",
                            Rating = 8.8000000000000007,
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            Year = 2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
