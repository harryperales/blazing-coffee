﻿// <auto-generated />
using BlazingCoffee.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingCoffee.Server.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    partial class CoffeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Continent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerCompanyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerContactName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<float>("Freight")
                        .HasColumnType("REAL");

                    b.Property<long>("OrderDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderID")
                        .HasColumnType("INTEGER");

                    b.Property<float>("OrderTotal")
                        .HasColumnType("REAL");

                    b.Property<long>("RequiredDate")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RequiredDateEnd")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RequiredDateStart")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipCountry")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipRegion")
                        .HasColumnType("TEXT");

                    b.Property<int>("ShipVia")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ShippedDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Budget")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<int>("ImgId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Target")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Locale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocaleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locales");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NutritionFileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sku")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BlazingCoffee.Shared.Models.Employee", b =>
                {
                    b.HasOne("BlazingCoffee.Shared.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
