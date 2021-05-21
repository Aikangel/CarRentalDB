using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalDB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Additional_services",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Service_code_1 = table.Column<long>(nullable: false),
                    Service_code_2 = table.Column<long>(nullable: false),
                    Service_code_3 = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additional_services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(nullable: true),
                    Paul = table.Column<int>(nullable: false),
                    Date_of_birth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Passport_details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_of_the_position = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    Responsibitities = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Passport_details = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Paul = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    PositionsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Positions_PositionsID",
                        column: x => x.PositionsID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration_number = table.Column<int>(nullable: false),
                    Return_mark = table.Column<string>(nullable: true),
                    Date_of_last_maintenance = table.Column<DateTime>(nullable: false),
                    Special_marks = table.Column<string>(nullable: true),
                    Rental_day_price = table.Column<int>(nullable: false),
                    Car_price = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Body_number = table.Column<int>(nullable: false),
                    Engine_number = table.Column<int>(nullable: false),
                    Year_of_release = table.Column<DateTime>(nullable: false),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Car_Brands",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Technical_specifications = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CarsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car_Brands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Car_Brands_Cars_CarsID",
                        column: x => x.CarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rental_services",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_of_issue = table.Column<DateTime>(nullable: false),
                    Rental_period = table.Column<DateTime>(nullable: false),
                    Return_Date = table.Column<DateTime>(nullable: false),
                    Rental_price = table.Column<int>(nullable: false),
                    Payment_mark = table.Column<string>(nullable: true),
                    Additional_servicesID = table.Column<long>(nullable: true),
                    CarsID = table.Column<long>(nullable: true),
                    CustomersID = table.Column<long>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental_services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rental_services_Additional_services_Additional_servicesID",
                        column: x => x.Additional_servicesID,
                        principalTable: "Additional_services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rental_services_Cars_CarsID",
                        column: x => x.CarsID,
                        principalTable: "Cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rental_services_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rental_services_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_Brands_CarsID",
                table: "Car_Brands",
                column: "CarsID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_StaffID",
                table: "Cars",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_services_Additional_servicesID",
                table: "Rental_services",
                column: "Additional_servicesID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_services_CarsID",
                table: "Rental_services",
                column: "CarsID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_services_CustomersID",
                table: "Rental_services",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_services_StaffID",
                table: "Rental_services",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PositionsID",
                table: "Staff",
                column: "PositionsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car_Brands");

            migrationBuilder.DropTable(
                name: "Rental_services");

            migrationBuilder.DropTable(
                name: "Additional_services");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
