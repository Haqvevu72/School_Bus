using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusId = table.Column<int>(type: "int", nullable: false),
                    StartPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passengers = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rides_Cars_BusId",
                        column: x => x.BusId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    BusId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Cars_BusId",
                        column: x => x.BusId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Created", "Password", "Updated", "Username" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5425), "admin", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5426), "admin" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5618), "ZU-051", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5618) },
                    { 2, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5620), "ZU-052", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5621) },
                    { 3, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5623), "ZU-053", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5623) },
                    { 4, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5625), "ZU-054", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5625) },
                    { 5, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5627), "ZU-055", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5627) },
                    { 6, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5629), "ZU-056", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5629) },
                    { 7, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5631), "ZU-057", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5632) },
                    { 8, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5633), "ZU-058", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5634) },
                    { 9, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5636), "ZU-059", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5636) },
                    { 10, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5638), "ZU-060", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5638) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Address", "Created", "FirstName", "LastName", "Phone", "Updated" },
                values: new object[,]
                {
                    { 1, "San-Francisco", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5806), "Daniel", "Cormier", "0509891232", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5807) },
                    { 2, "New York", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5810), "Michael", "Johnson", "0509894567", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5810) },
                    { 3, "Los Angeles", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5812), "Emily", "Smith", "0509897890", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5813) },
                    { 4, "Chicago", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5815), "John", "Brown", "0509892345", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5815) },
                    { 5, "Miami", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5817), "Olivia", "Miller", "0509896789", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5818) },
                    { 6, "San Diego", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5820), "Lucas", "Davis", "0509894321", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5821) },
                    { 7, "Seattle", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5822), "Ava", "Garcia", "0509898765", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5823) },
                    { 8, "Boston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5825), "Liam", "Martinez", "0509892109", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5825) },
                    { 9, "Houston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5827), "Mia", "Clark", "0509895432", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5828) },
                    { 10, "Denver", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5830), "Noah", "Taylor", "0509898765", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5830) },
                    { 11, "San-Francisco", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5833), "Sophia", "Walker", "0509891232", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5834) },
                    { 12, "New York", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5835), "William", "White", "0509894567", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5836) },
                    { 13, "Los Angeles", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5838), "Emma", "Jones", "0509897890", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5838) },
                    { 14, "Chicago", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5840), "James", "Wilson", "0509892345", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5841) },
                    { 15, "Miami", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5844), "Isabella", "Jackson", "0509896789", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5845) },
                    { 16, "San Diego", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5847), "Benjamin", "Harris", "0509894321", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5847) },
                    { 17, "Seattle", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5849), "Lucy", "Turner", "0509898765", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5849) },
                    { 18, "Boston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5851), "Logan", "Smith", "0509892109", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5852) },
                    { 19, "Houston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5854), "Ella", "Anderson", "0509895432", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5855) },
                    { 20, "Denver", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5857), "Alexander", "Brown", "0509898765", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5857) },
                    { 21, "San-Francisco", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5859), "Oliver", "Garcia", "0509891232", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5859) },
                    { 22, "New York", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5861), "Mia", "Johnson", "0509894567", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5862) },
                    { 23, "Los Angeles", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5863), "William", "Gonzalez", "0509897890", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5864) }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "Created", "FirstName", "LastName", "Phone", "Updated" },
                values: new object[,]
                {
                    { 1, "Sumqayit City", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5717), "Ali", "Muradov", "0555555555", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5718) },
                    { 2, "Istanbul", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5720), "Ayse", "Kara", "0555123456", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5721) },
                    { 3, "New York", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5722), "David", "Brown", "0555234567", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5723) },
                    { 4, "Los Angeles", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5725), "Sophia", "Smith", "0555345678", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5726) },
                    { 5, "Chicago", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5727), "John", "Johnson", "0555456789", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5728) },
                    { 6, "Miami", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5730), "Emma", "Wilson", "0555567890", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5730) },
                    { 7, "San Diego", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5732), "Michael", "Harris", "0555678901", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5733) },
                    { 8, "Seattle", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5735), "Olivia", "Davis", "0555789012", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5735) }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "Created", "FirstName", "LastName", "Phone", "Updated" },
                values: new object[] { 9, "Boston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5737), "Lucas", "Miller", "0555890123", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "Created", "FirstName", "LastName", "Phone", "Updated" },
                values: new object[] { 10, "Houston", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5739), "Ava", "Clark", "0555101234", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Capacity", "Created", "DriverId", "Number", "Updated" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5300), 1, "01-AA-001", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5301) },
                    { 2, 18, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5303), 2, "02-BB-002", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5304) },
                    { 3, 25, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5306), 3, "03-CC-003", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5306) },
                    { 4, 22, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5308), 4, "04-DD-004", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5308) },
                    { 5, 30, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5311), 5, "05-EE-005", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5311) },
                    { 6, 21, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5313), 6, "06-FF-006", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5314) },
                    { 7, 28, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5315), 7, "07-GG-007", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5316) },
                    { 8, 24, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5317), 8, "08-HH-008", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5318) },
                    { 9, 19, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5320), 9, "09-II-009", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5320) },
                    { 10, 15, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5322), 10, "10-JJ-010", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(5322) }
                });

            migrationBuilder.InsertData(
                table: "Rides",
                columns: new[] { "Id", "BusId", "Created", "EndPoint", "Passengers", "StartPoint", "Updated" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4250), "Liverpool", 10, "Manchester", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4250) },
                    { 2, 2, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4253), "Birmingham", 15, "London", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4253) },
                    { 3, 3, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4256), "Edinburgh", 12, "Glasgow", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4256) },
                    { 4, 4, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4258), "Boston", 8, "New York", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4259) },
                    { 5, 5, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4260), "San Francisco", 20, "Los Angeles", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4261) },
                    { 6, 6, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4263), "Amsterdam", 16, "Paris", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4263) },
                    { 7, 7, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4265), "Melbourne", 18, "Sydney", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4266) },
                    { 8, 8, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4267), "Munich", 14, "Berlin", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4268) },
                    { 9, 9, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4270), "Osaka", 11, "Tokyo", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4270) },
                    { 10, 10, new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4272), "Florence", 9, "Rome", new DateTime(2023, 11, 1, 14, 46, 45, 216, DateTimeKind.Local).AddTicks(4273) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BusId", "ClassId", "Created", "FirstName", "LastName", "ParentId", "Updated" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7025), "Elgun", "Haqverdiyev", 1, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7026) },
                    { 2, 2, 2, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7029), "Alice", "Johnson", 2, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7029) },
                    { 3, 3, 3, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7031), "John", "Smith", 3, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7032) },
                    { 4, 4, 4, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7034), "Emily", "Wilson", 4, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7034) },
                    { 5, 5, 5, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7036), "David", "Brown", 5, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7037) },
                    { 6, 6, 6, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7038), "Sophia", "Miller", 6, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7039) },
                    { 7, 7, 7, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7041), "Oliver", "Davis", 7, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7041) },
                    { 8, 8, 8, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7043), "Lily", "Garcia", 8, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7044) },
                    { 9, 9, 9, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7045), "Ethan", "Martinez", 9, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7046) },
                    { 10, 10, 10, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7048), "Ava", "Clark", 10, new DateTime(2023, 11, 1, 14, 46, 45, 215, DateTimeKind.Local).AddTicks(7049) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DriverId",
                table: "Cars",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rides_BusId",
                table: "Rides",
                column: "BusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_BusId",
                table: "Students",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Rides");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
