﻿// <auto-generated />
using HRManagement.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace HRManagement.DataAccess.Migrations
{
    [DbContext(typeof(HRManagementDBContext))]
    partial class HRManagementDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("BillingType")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Strada Industriei nr. 2-4,28,Cluj-Napoca, 810391, Romania",
                            BillingType = 3,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Porsche engineers and manufactures premium and luxury sports cars and sports crossovers",
                            Email = "porsche-romania@gmail.com",
                            IsActive = true,
                            Name = "Porsche",
                            PhoneNumber = "0350411457",
                            VAT = 10.5m
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Strada Focsani nr. 87-101; 88-106,34,Cluj-Napoca, 810166, Romania",
                            BillingType = 3,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Tire & Innovation Company",
                            Email = "continental-romania@gmail.com",
                            IsActive = true,
                            Name = "Continental",
                            PhoneNumber = "0722363026",
                            VAT = 9.4m
                        },
                        new
                        {
                            Id = 3L,
                            Address = "Bulevard Iorga Nicolae bl. 901-905,30,Cluj-Napoca, 700212, Romania",
                            BillingType = 2,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "develops, manufactures, and sells automobiles and motorcycles, spare parts and accessories, and engines.",
                            Email = "bmw-romania@gmail.com",
                            IsActive = true,
                            Name = "BMW",
                            PhoneNumber = "0256362560",
                            VAT = 19.9m
                        },
                        new
                        {
                            Id = 4L,
                            Address = "Strada Scortan Ion nr. 103-T,23,Cluj-Napoca, 22663, Romania",
                            BillingType = 2,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "engages in design, engineering, production, and sale of luxury performance sports cars",
                            Email = "ferarri-romania@gmail.com",
                            IsActive = true,
                            Name = "Ferarri",
                            PhoneNumber = "0269560205",
                            VAT = 12.2m
                        },
                        new
                        {
                            Id = 5L,
                            Address = "Strada Lainici nr. 2-T,5,Cluj-Napoca, 12252, Romania",
                            BillingType = 2,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "designs, develops, manufactures, and commercializes premium cars",
                            Email = "audi-romania@gmail.com",
                            IsActive = false,
                            Name = "Audi",
                            PhoneNumber = "0213374256",
                            VAT = 25m
                        },
                        new
                        {
                            Id = 6L,
                            Address = "Strada Balotesti,2,Cluj-Napoca, 110328, Romania",
                            BillingType = 1,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "designs, develops, and manufactures power and propulsion systems",
                            Email = "rolls-royce-romania@gmail.com",
                            IsActive = true,
                            Name = "Rolls-Royce",
                            PhoneNumber = "0265311052",
                            VAT = 11.8m
                        },
                        new
                        {
                            Id = 7L,
                            Address = "Strada Fluturilor,27,Cluj-Napoca, 700616, Romania",
                            BillingType = 1,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "sports cars, super cars, and electronic control systems ",
                            Email = "mclaren-romania@gmail.com",
                            IsActive = false,
                            Name = "McLaren",
                            PhoneNumber = "0268413201",
                            VAT = 23m
                        },
                        new
                        {
                            Id = 8L,
                            Address = "Bulevard Dacia,9,Cluj-Napoca, 330106, Romania",
                            BillingType = 1,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "automobile manufacturer",
                            Email = "toyota-romania@gmail.com",
                            IsActive = false,
                            Name = "Toyota",
                            PhoneNumber = "0724202027",
                            VAT = 15m
                        },
                        new
                        {
                            Id = 9L,
                            Address = "Strada Siragului nr. 1-T,28,Cluj-Napoca, 22635, Romania",
                            BillingType = 1,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "exclusive sports car brand with a unique heritage instantly recognised around the world",
                            Email = "aston-martin-romania@gmail.com",
                            IsActive = true,
                            Name = "Aston Martin",
                            PhoneNumber = "0359415381",
                            VAT = 19.8m
                        },
                        new
                        {
                            Id = 10L,
                            Address = "Strada Amurgului nr. 3; 6-T,9,Cluj-Napoca, 700442, Romania",
                            BillingType = 0,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Italian manufacturer of luxury sports cars and SUV",
                            Email = "lamborghini-romania@gmail.com",
                            IsActive = false,
                            Name = "Lamborghini",
                            PhoneNumber = "0264255684",
                            VAT = 23m
                        },
                        new
                        {
                            Id = 11L,
                            Address = "Alee Margaretelor nr. 9,33,Cluj-Napoca, 810511, Romania",
                            BillingType = 0,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Italian luxury vehicle manufacturer",
                            Email = "maserati-romania@gmail.com",
                            IsActive = true,
                            Name = "Maserati",
                            PhoneNumber = "0744826728",
                            VAT = 15m
                        },
                        new
                        {
                            Id = 12L,
                            Address = "Strada Moroeni nr. 52-58,31,Cluj-Napoca, 23033, Romania",
                            BillingType = 0,
                            Country = "Romania",
                            DateCreated = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "British multinational automobile manufacturer which produces luxury vehicles and sport utility vehicles.",
                            Email = "jaguar-romania@gmail.com",
                            IsActive = false,
                            Name = "Jaguar",
                            PhoneNumber = "0745311046",
                            VAT = 23m
                        });
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Document", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CustomerId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CustomerId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CustomerId = 2L
                        },
                        new
                        {
                            Id = 4L,
                            CustomerId = 2L
                        });
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Date = new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Celebrating Romanian National Day.",
                            Location = 0,
                            Title = "National day",
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            Date = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Celebrating 10 years of Red to Blue.",
                            Location = 0,
                            Title = "Red to Blue 10th anniversary.",
                            Type = 0
                        });
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("DaysOff")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DaysOff = 14,
                            Department = "Finance",
                            Email = "jane.doe@red-to-blue.com",
                            FirstName = "Jane",
                            JobTitle = "Finance Manager",
                            LastName = "Doe",
                            PhoneNumber = "0123456789",
                            Picture = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = 2
                        },
                        new
                        {
                            Id = 2L,
                            DaysOff = 9,
                            Department = "Development",
                            Email = "ted.marshal@red-to-blue.com",
                            FirstName = "Ted",
                            JobTitle = "Front-End Developer",
                            LastName = "Marshal",
                            PhoneNumber = "9876543210",
                            Picture = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = 0
                        },
                        new
                        {
                            Id = 3L,
                            DaysOff = 6,
                            Department = "HR",
                            Email = "sofia.atkinson@red-to-blue.com",
                            FirstName = "Sofia",
                            JobTitle = "Human Resources",
                            LastName = "Atkinson",
                            PhoneNumber = "0918273465",
                            Picture = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = 1
                        });
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Document", b =>
                {
                    b.HasOne("HRManagement.DataAccess.Entities.Customer", null)
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Event", b =>
                {
                    b.HasOne("HRManagement.DataAccess.Entities.User", null)
                        .WithMany("Events")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.Customer", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("HRManagement.DataAccess.Entities.User", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
