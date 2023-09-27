using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using HRManagement.DataAccess.Enums;

namespace HRManagement.DataAccess.DbContexts
{
    public class HRManagementDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;

        public HRManagementDBContext(DbContextOptions<HRManagementDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    Id = 1,
                    Name = "Porsche",
                    Address = "Strada Industriei nr. 2-4,28,Cluj-Napoca, 810391, Romania",
                    Email = "porsche-romania@gmail.com",
                    PhoneNumber = "0350411457",
                    Country = "Romania",
                    VAT = 10.5m,
                    BillingType = BillingType.Yearly,
                    Details = "Porsche engineers and manufactures premium and luxury sports cars and sports crossovers",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 06),
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Continental",
                    Address = "Strada Focsani nr. 87-101; 88-106,34,Cluj-Napoca, 810166, Romania",
                    Email = "continental-romania@gmail.com",
                    PhoneNumber = "0722363026",
                    Country = "Romania",
                    VAT = 9.4m,
                    BillingType = BillingType.Yearly,
                    Details = "Tire & Innovation Company",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 06),
                },
                new Customer()
                {
                    Id = 3,
                    Name = "BMW",
                    Address = "Bulevard Iorga Nicolae bl. 901-905,30,Cluj-Napoca, 700212, Romania",
                    Email = "bmw-romania@gmail.com",
                    PhoneNumber = "0256362560",
                    Country = "Romania",
                    VAT = 19.9m,
                    BillingType = BillingType.Monthly,
                    Details = "develops, manufactures, and sells automobiles and motorcycles, spare parts and accessories, and engines.",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 05),
                },
                new Customer()
                {
                    Id = 4,
                    Name = "Ferarri",
                    Address = "Strada Scortan Ion nr. 103-T,23,Cluj-Napoca, 22663, Romania",
                    Email = "ferarri-romania@gmail.com",
                    PhoneNumber = "0269560205",
                    Country = "Romania",
                    VAT = 12.2m,
                    BillingType = BillingType.Monthly,
                    Details = "engages in design, engineering, production, and sale of luxury performance sports cars",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 05),
                },
                new Customer()
                {
                    Id = 5,
                    Name = "Audi",
                    Address = "Strada Lainici nr. 2-T,5,Cluj-Napoca, 12252, Romania",
                    Email = "audi-romania@gmail.com",
                    PhoneNumber = "0213374256",
                    Country = "Romania",
                    VAT = 25m,
                    BillingType = BillingType.Monthly,
                    Details = "designs, develops, manufactures, and commercializes premium cars",
                    IsActive = false,
                    DateCreated = new DateTime(2023, 09, 04),
                },
                new Customer()
                {
                    Id = 6,
                    Name = "Rolls-Royce",
                    Address = "Strada Balotesti,2,Cluj-Napoca, 110328, Romania",
                    Email = "rolls-royce-romania@gmail.com",
                    PhoneNumber = "0265311052",
                    Country = "Romania",
                    VAT = 11.8m,
                    BillingType = BillingType.Weekly,
                    Details = "designs, develops, and manufactures power and propulsion systems",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 04),
                },
                new Customer()
                {
                    Id = 7,
                    Name = "McLaren",
                    Address = "Strada Fluturilor,27,Cluj-Napoca, 700616, Romania",
                    Email = "mclaren-romania@gmail.com",
                    PhoneNumber = "0268413201",
                    Country = "Romania",
                    VAT = 23m,
                    BillingType = BillingType.Weekly,
                    Details = "sports cars, super cars, and electronic control systems ",
                    IsActive = false,
                    DateCreated = new DateTime(2023, 09, 03),
                },
                new Customer()
                {
                    Id = 8,
                    Name = "Toyota",
                    Address = "Bulevard Dacia,9,Cluj-Napoca, 330106, Romania",
                    Email = "toyota-romania@gmail.com",
                    PhoneNumber = "0724202027",
                    Country = "Romania",
                    VAT = 15m,
                    BillingType = BillingType.Weekly,
                    Details = "automobile manufacturer",
                    IsActive = false,
                    DateCreated = new DateTime(2023, 09, 03),
                },
                new Customer()
                {
                    Id = 9,
                    Name = "Aston Martin",
                    Address = "Strada Siragului nr. 1-T,28,Cluj-Napoca, 22635, Romania",
                    Email = "aston-martin-romania@gmail.com",
                    PhoneNumber = "0359415381",
                    Country = "Romania",
                    VAT = 19.8m,
                    BillingType = BillingType.Weekly,
                    Details = "exclusive sports car brand with a unique heritage instantly recognised around the world",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 02),
                },
                new Customer()
                {
                    Id = 10,
                    Name = "Lamborghini",
                    Address = "Strada Amurgului nr. 3; 6-T,9,Cluj-Napoca, 700442, Romania",
                    Email = "lamborghini-romania@gmail.com",
                    PhoneNumber = "0264255684",
                    Country = "Romania",
                    VAT = 23m,
                    BillingType = BillingType.Daily,
                    Details = "Italian manufacturer of luxury sports cars and SUV",
                    IsActive = false,
                    DateCreated = new DateTime(2023, 09, 02),
                },
                new Customer()
                {
                    Id = 11,
                    Name = "Maserati",
                    Address = "Alee Margaretelor nr. 9,33,Cluj-Napoca, 810511, Romania",
                    Email = "maserati-romania@gmail.com",
                    PhoneNumber = "0744826728",
                    Country = "Romania",
                    VAT = 15m,
                    BillingType = BillingType.Daily,
                    Details = "Italian luxury vehicle manufacturer",
                    IsActive = true,
                    DateCreated = new DateTime(2023, 09, 01),
                },
                new Customer()
                {
                    Id = 12,
                    Name = "Jaguar",
                    Address = "Strada Moroeni nr. 52-58,31,Cluj-Napoca, 23033, Romania",
                    Email = "jaguar-romania@gmail.com",
                    PhoneNumber = "0745311046",
                    Country = "Romania",
                    VAT = 23m,
                    BillingType = BillingType.Daily,
                    Details = "British multinational automobile manufacturer which produces luxury vehicles and sport utility vehicles.",
                    IsActive = false,
                    DateCreated = new DateTime(2023, 09, 01),
                });

            modelBuilder.Entity<Document>().HasData(
                new Document()
                {
                    Id = 1,
                    CustomerId = 1,
                    Title = "Contract",
                    CreationDate = new DateTime(2023, 09, 01),
                    Content = new Byte[10],
                },
                new Document()
                {
                    Id = 2,
                    CustomerId = 1,
                    Title = "Billing Proof",
                    CreationDate = new DateTime(2023, 09, 02),
                    Content = new Byte[20],
                },
                new Document()
                {
                    Id = 3,
                    CustomerId = 2,
                    Title = "Billing Proof",
                    CreationDate = new DateTime(2023, 09, 02),
                    Content = new Byte[20],
                },
                new Document()
                {
                    Id = 4,
                    CustomerId = 2,
                    Title = "Contract",
                    CreationDate = new DateTime(2023, 09, 01),
                    Content = new Byte[10],
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Role = RoleType.Finance,
                    Email = "jane.doe@red-to-blue.com",
                    JobTitle = "Finance Manager",
                    Department = "Finance",
                    Picture = new Byte[10],
                    PhoneNumber = "0123456789",
                    DaysOff = 14,
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Ted",
                    LastName = "Marshal",
                    Role = RoleType.General,
                    Email = "ted.marshal@red-to-blue.com",
                    JobTitle = "Front-End Developer",
                    Department = "Development",
                    Picture = new Byte[10],
                    PhoneNumber = "9876543210",
                    DaysOff = 9,
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Sofia",
                    LastName = "Atkinson",
                    Role = RoleType.HR,
                    Email = "sofia.atkinson@red-to-blue.com",
                    JobTitle = "Human Resources",
                    Department = "HR",
                    Picture = new Byte[10],
                    PhoneNumber = "0918273465",
                    DaysOff = 6,
                });

            modelBuilder.Entity<Event>().HasData(
                new Event()
                {
                    Id = 1,
                    Title = "National day",
                    Description = "Celebrating Romanian National Day.",
                    Date = new DateTime(2023, 12, 01),
                    Location = LocationType.Online,
                    Type = EventType.General
                },

                new Event()
                {
                    Id = 2,
                    Title = "Red to Blue 10th anniversary.",
                    Description = "Celebrating 10 years of Red to Blue.",
                    Date = new DateTime(2024, 08, 20),
                    Location = LocationType.Online,
                    Type = EventType.General
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
