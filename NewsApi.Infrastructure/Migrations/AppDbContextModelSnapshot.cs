﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsApi.Infrastructure.Context;

#nullable disable

namespace NewsApi.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewsApi.Core.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aucthors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Kyiv",
                            Email = "sara@ua",
                            Name = "Sara",
                            NewsId = 1,
                            Surname = "Ivanova"
                        },
                        new
                        {
                            Id = 2,
                            City = "Kyiv",
                            Email = "dima@ua",
                            Name = "Dima",
                            NewsId = 2,
                            Surname = "Dallas"
                        },
                        new
                        {
                            Id = 3,
                            City = "Kyiv",
                            Email = "ira@ua",
                            Name = "Ira",
                            NewsId = 3,
                            Surname = "Dmitrivna"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Category about sport",
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Category about cience",
                            Name = "Cience"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<long>("CountNewsOpen")
                        .HasColumnType("bigint");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 1,
                            CountNewsOpen = 2L,
                            Information = "There is no time to hesitate",
                            Name = "New Kyiv"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 1,
                            CountNewsOpen = 0L,
                            Information = "Freud's conditioning",
                            Name = "New Kyiv"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CategoryId = 2,
                            CountNewsOpen = 0L,
                            Information = "Rebrov recently received an offer to head the club",
                            Name = "Sport Kyiv"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Redactor"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "Writer"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrowserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cyti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrowserName = "Chrome",
                            Cyti = "Rivne",
                            IP = "127.127.000.255",
                            NewsId = 1,
                            OS = "Windows"
                        },
                        new
                        {
                            Id = 2,
                            BrowserName = "Mazila",
                            Cyti = "Kyiv",
                            IP = "127.127.000.285",
                            NewsId = 1,
                            OS = "Windows"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "sa@gmail.com",
                            FirstName = "Sars",
                            LastName = "Ivanova",
                            Password = "123",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "dimas@gmail.com",
                            FirstName = "Dima",
                            LastName = "Sergiovich",
                            Password = "121",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "isa@gmail.com",
                            FirstName = "Isaak",
                            LastName = "Dmitrovich",
                            Password = "223",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 4,
                            Email = "ira@gmail.com",
                            FirstName = "Ira",
                            LastName = "Iackivna",
                            Password = "111",
                            RoleId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
