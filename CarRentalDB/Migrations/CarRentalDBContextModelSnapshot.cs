// <auto-generated />
using System;
using CarRentalDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalDB.Migrations
{
    [DbContext(typeof(CarRentalDBContext))]
    partial class CarRentalDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Models.Additional_services", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("Service_code_1")
                        .HasColumnType("bigint");

                    b.Property<long>("Service_code_2")
                        .HasColumnType("bigint");

                    b.Property<long>("Service_code_3")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Additional_services");
                });

            modelBuilder.Entity("DB.Models.Car_Brands", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CarsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technical_specifications")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.ToTable("Car_Brands");
                });

            modelBuilder.Entity("DB.Models.Cars", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Body_number")
                        .HasColumnType("int");

                    b.Property<int>("Car_price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_of_last_maintenance")
                        .HasColumnType("datetime2");

                    b.Property<int>("Engine_number")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int>("Registration_number")
                        .HasColumnType("int");

                    b.Property<int>("Rental_day_price")
                        .HasColumnType("int");

                    b.Property<string>("Return_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Special_marks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Year_of_release")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DB.Models.Customers", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Paul")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DB.Models.Positions", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name_of_the_position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibitities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DB.Models.Rental_services", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Additional_servicesID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CarsID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CustomersID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date_of_issue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Rental_period")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rental_price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Return_Date")
                        .HasColumnType("datetime2");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("Additional_servicesID");

                    b.HasIndex("CarsID");

                    b.HasIndex("CustomersID");

                    b.HasIndex("StaffID");

                    b.ToTable("Rental_services");
                });

            modelBuilder.Entity("DB.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<long?>("PositionsID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("PositionsID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("DB.Models.Car_Brands", b =>
                {
                    b.HasOne("DB.Models.Cars", null)
                        .WithMany("Brand_code")
                        .HasForeignKey("CarsID");
                });

            modelBuilder.Entity("DB.Models.Cars", b =>
                {
                    b.HasOne("DB.Models.Staff", null)
                        .WithMany("Vehicle_code")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("DB.Models.Rental_services", b =>
                {
                    b.HasOne("DB.Models.Additional_services", null)
                        .WithMany("Rental_services")
                        .HasForeignKey("Additional_servicesID");

                    b.HasOne("DB.Models.Cars", null)
                        .WithMany("Rental_code")
                        .HasForeignKey("CarsID");

                    b.HasOne("DB.Models.Customers", null)
                        .WithMany("Rental_code")
                        .HasForeignKey("CustomersID");

                    b.HasOne("DB.Models.Staff", null)
                        .WithMany("Rental_code")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("DB.Models.Staff", b =>
                {
                    b.HasOne("DB.Models.Positions", null)
                        .WithMany("Employee_Code")
                        .HasForeignKey("PositionsID");
                });
#pragma warning restore 612, 618
        }
    }
}
