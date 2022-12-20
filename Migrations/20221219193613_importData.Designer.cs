﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesManagment.Data;

#nullable disable

namespace SalesManagment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221219193613_importData")]
    partial class importData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesManagment.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetailOutletId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "james.tailor@company.com",
                            FirstName = "James",
                            JobTitle = "Buyer",
                            Phone = "000000000",
                            RetailOutletId = 1,
                            Surname = "Tailor"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jill.hutton@company.com",
                            FirstName = "Jill",
                            JobTitle = "Buyer",
                            Phone = "000000000",
                            RetailOutletId = 2,
                            Surname = "Hutton"
                        },
                        new
                        {
                            Id = 3,
                            Email = "craig.rice@company.com",
                            FirstName = "Craig",
                            JobTitle = "Buyer",
                            Phone = "000000000",
                            RetailOutletId = 3,
                            Surname = "Rice"
                        },
                        new
                        {
                            Id = 4,
                            Email = "amy.smith@company.com",
                            FirstName = "Amy",
                            JobTitle = "Buyer",
                            Phone = "000000000",
                            RetailOutletId = 4,
                            Surname = "Smith"
                        });
                });

            modelBuilder.Entity("SalesManagment.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeTitleId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportToEmpId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1974, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.jones@oexl.com",
                            EmployeeTitleId = 1,
                            FirstName = "Bob",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/BobJones.jpg",
                            Surname = "Jones"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jenny.marks@oexl.com",
                            EmployeeTitleId = 2,
                            FirstName = "Jenny",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/JennyMarks.jpg",
                            ReportToEmpId = 1,
                            Surname = "Marks"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "henry.andrews@oexl.com",
                            EmployeeTitleId = 2,
                            FirstName = "Henry",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/HenryAndrews.jpg",
                            ReportToEmpId = 1,
                            Surname = "Andrews"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.jameson@oexl.com",
                            EmployeeTitleId = 2,
                            FirstName = "John",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/JohnJameson.jpg",
                            ReportToEmpId = 1,
                            Surname = "Jameson"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "noah.robinson@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Noah",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/NoahRobinson.jpg",
                            ReportToEmpId = 2,
                            Surname = "Robinson"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elijah.hamilton@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Elijah",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/ElijahHamilton.jpg",
                            ReportToEmpId = 2,
                            Surname = "Hamilton"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1992, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jamie.fisher@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Jamie",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/JamieFisher.jpg",
                            ReportToEmpId = 2,
                            Surname = "Fisher"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "olivia.mills@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Olivia",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/OliviaMills.jpg",
                            ReportToEmpId = 3,
                            Surname = "Mills"
                        },
                        new
                        {
                            Id = 9,
                            DateOfBirth = new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "benjamin.lucas@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Benjamin",
                            Gender = "Male",
                            ImagePath = "/Images/Profile/BenjaminLucas.jpg",
                            ReportToEmpId = 3,
                            Surname = "Lucas"
                        },
                        new
                        {
                            Id = 10,
                            DateOfBirth = new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarah.henderson@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Sarah",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/SarahHenderson.jpg",
                            ReportToEmpId = 3,
                            Surname = "Henderson"
                        },
                        new
                        {
                            Id = 11,
                            DateOfBirth = new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emma.lee@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Emma",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/EmmaLee.jpg",
                            ReportToEmpId = 4,
                            Surname = "Lee"
                        },
                        new
                        {
                            Id = 12,
                            DateOfBirth = new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ava.williams@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Ava",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/AvaWilliams.jpg",
                            ReportToEmpId = 4,
                            Surname = "Williams"
                        },
                        new
                        {
                            Id = 13,
                            DateOfBirth = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "angela.moore@oexl.com",
                            EmployeeTitleId = 3,
                            FirstName = "Angela",
                            Gender = "Female",
                            ImagePath = "/Images/Profile/AngelaMoore.jpg",
                            ReportToEmpId = 4,
                            Surname = "Moore"
                        });
                });

            modelBuilder.Entity("SalesManagment.Entities.EmployeeJobTitle", b =>
                {
                    b.Property<int>("EmployeeTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTitleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeTitleId");

                    b.ToTable("EmployeeJobTitles");

                    b.HasData(
                        new
                        {
                            EmployeeTitleId = 1,
                            Description = "Sales Manager",
                            Name = "SM"
                        },
                        new
                        {
                            EmployeeTitleId = 2,
                            Description = "Team Leader",
                            Name = "TL"
                        },
                        new
                        {
                            EmployeeTitleId = 3,
                            Description = "Sales Rep",
                            Name = "SR"
                        });
                });

            modelBuilder.Entity("SalesManagment.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/13600k.jpg",
                            Name = "i5 13600K",
                            Price = 200m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/13700k.jpg",
                            Name = "I7-13700K ",
                            Price = 210m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/rtx2080.jpg",
                            Name = "RTX 2080 FE",
                            Price = 500m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/rtx3080.jpg",
                            Name = "RTX 3080 FE",
                            Price = 800m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/rtx4080.jpg",
                            Name = "RTX 4080 FE",
                            Price = 252m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/rtx4090.jpg",
                            Name = "RTX 4090 FE",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/pf1.jpg",
                            Name = "POCO F1",
                            Price = 230m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/s22.jpg",
                            Name = "Samsung s22",
                            Price = 600m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/IPhone13.jpg",
                            Name = "IPhone13",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/IPhone14.jpg",
                            Name = "IPhone14",
                            Price = 1600m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/IPhone14Pro.jpg",
                            Name = "IPhone14 PRO",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/IPhone14ProMax.jpg",
                            Name = "IPhone14 ProMax",
                            Price = 4000m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/MacBook.jpg",
                            Name = "MacBook",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/Razer.jpg",
                            Name = "Razer",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/Surface.jpg",
                            Name = "Surface",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/ram.jpg",
                            Name = "RAM 8gb",
                            Price = 60m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/ram.jpg",
                            Name = "RAM 16gb",
                            Price = 100m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/ram.jpg",
                            Name = "RAM 32gb",
                            Price = 200m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 5,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/ram.jpg",
                            Name = "RAM 64gb",
                            Price = 300m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 6,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/ssd1t.jpg",
                            Name = "SSD 1Tb",
                            Price = 100m
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 6,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/m2tb.jpg",
                            Name = "SSD m.2 2Tb",
                            Price = 200m
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 6,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/m2tb.jpg",
                            Name = "SSD m.2 5Tb",
                            Price = 400m
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 7,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/mb1.jpg",
                            Name = "MB 1",
                            Price = 200m
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 7,
                            Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                            ImgPath = "/Images/Products/mb1.jpg",
                            Name = "MB 2",
                            Price = 400m
                        });
                });

            modelBuilder.Entity("SalesManagment.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CPU"
                        },
                        new
                        {
                            Id = 2,
                            Name = "GPU"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 5,
                            Name = "RAM"
                        },
                        new
                        {
                            Id = 6,
                            Name = "SSD"
                        },
                        new
                        {
                            Id = 7,
                            Name = "motherboard"
                        });
                });

            modelBuilder.Entity("SalesManagment.Entities.RetailOutlet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RetailOutlets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "TX",
                            Name = "Texas Outdoor Store"
                        },
                        new
                        {
                            Id = 2,
                            Location = "CA",
                            Name = "California Outdoor Store"
                        },
                        new
                        {
                            Id = 3,
                            Location = "NY",
                            Name = "New York Outdoor Store"
                        },
                        new
                        {
                            Id = 4,
                            Location = "WA",
                            Name = " Washington Outdoor Store"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
