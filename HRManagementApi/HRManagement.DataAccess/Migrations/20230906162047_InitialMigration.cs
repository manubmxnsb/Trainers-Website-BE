using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BillingType = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOff = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BillingType", "Country", "DateCreated", "Details", "Email", "IsActive", "Name", "PhoneNumber", "VAT" },
                values: new object[,]
                {
                    { 1L, "Strada Industriei nr. 2-4,28,Cluj-Napoca, 810391, Romania", 3, "Romania", new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porsche engineers and manufactures premium and luxury sports cars and sports crossovers", "porsche-romania@gmail.com", true, "Porsche", "0350411457", 10.5m },
                    { 2L, "Strada Focsani nr. 87-101; 88-106,34,Cluj-Napoca, 810166, Romania", 3, "Romania", new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tire & Innovation Company", "continental-romania@gmail.com", true, "Continental", "0722363026", 9.4m },
                    { 3L, "Bulevard Iorga Nicolae bl. 901-905,30,Cluj-Napoca, 700212, Romania", 2, "Romania", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "develops, manufactures, and sells automobiles and motorcycles, spare parts and accessories, and engines.", "bmw-romania@gmail.com", true, "BMW", "0256362560", 19.9m },
                    { 4L, "Strada Scortan Ion nr. 103-T,23,Cluj-Napoca, 22663, Romania", 2, "Romania", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "engages in design, engineering, production, and sale of luxury performance sports cars", "ferarri-romania@gmail.com", true, "Ferarri", "0269560205", 12.2m },
                    { 5L, "Strada Lainici nr. 2-T,5,Cluj-Napoca, 12252, Romania", 2, "Romania", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "designs, develops, manufactures, and commercializes premium cars", "audi-romania@gmail.com", false, "Audi", "0213374256", 25m },
                    { 6L, "Strada Balotesti,2,Cluj-Napoca, 110328, Romania", 1, "Romania", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "designs, develops, and manufactures power and propulsion systems", "rolls-royce-romania@gmail.com", true, "Rolls-Royce", "0265311052", 11.8m },
                    { 7L, "Strada Fluturilor,27,Cluj-Napoca, 700616, Romania", 1, "Romania", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sports cars, super cars, and electronic control systems ", "mclaren-romania@gmail.com", false, "McLaren", "0268413201", 23m },
                    { 8L, "Bulevard Dacia,9,Cluj-Napoca, 330106, Romania", 1, "Romania", new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "automobile manufacturer", "toyota-romania@gmail.com", false, "Toyota", "0724202027", 15m },
                    { 9L, "Strada Siragului nr. 1-T,28,Cluj-Napoca, 22635, Romania", 1, "Romania", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "exclusive sports car brand with a unique heritage instantly recognised around the world", "aston-martin-romania@gmail.com", true, "Aston Martin", "0359415381", 19.8m },
                    { 10L, "Strada Amurgului nr. 3; 6-T,9,Cluj-Napoca, 700442, Romania", 0, "Romania", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian manufacturer of luxury sports cars and SUV", "lamborghini-romania@gmail.com", false, "Lamborghini", "0264255684", 23m },
                    { 11L, "Alee Margaretelor nr. 9,33,Cluj-Napoca, 810511, Romania", 0, "Romania", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian luxury vehicle manufacturer", "maserati-romania@gmail.com", true, "Maserati", "0744826728", 15m },
                    { 12L, "Strada Moroeni nr. 52-58,31,Cluj-Napoca, 23033, Romania", 0, "Romania", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "British multinational automobile manufacturer which produces luxury vehicles and sport utility vehicles.", "jaguar-romania@gmail.com", false, "Jaguar", "0745311046", 23m }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "Location", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrating Romanian National Day.", 0, "National day", 0, null },
                    { 2L, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrating 10 years of Red to Blue.", 0, "Red to Blue 10th anniversary.", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DaysOff", "Department", "Email", "FirstName", "JobTitle", "LastName", "PhoneNumber", "Picture", "Role" },
                values: new object[,]
                {
                    { 1L, 14, "Finance", "jane.doe@red-to-blue.com", "Jane", "Finance Manager", "Doe", "0123456789", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 2 },
                    { 2L, 9, "Development", "ted.marshal@red-to-blue.com", "Ted", "Front-End Developer", "Marshal", "9876543210", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0 },
                    { 3L, 6, "HR", "sofia.atkinson@red-to-blue.com", "Sofia", "Human Resources", "Atkinson", "0918273465", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 1 }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Content", "CreationDate", "CustomerId", "Title" },
                values: new object[,]
                {
                    { 1L, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Contract" },
                    { 2L, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Billing Proof" },
                    { 3L, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, "Billing Proof" },
                    { 4L, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, "Contract" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CustomerId",
                table: "Documents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
