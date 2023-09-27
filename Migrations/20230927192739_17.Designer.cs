﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradingWebAppFinalProject.Data;

#nullable disable

namespace TradingWebAppFinalProject.Migrations
{
    [DbContext(typeof(TradingWarehouseDataBase))]
    [Migration("20230927192739_17")]
    partial class _17
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContainingCountryCountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ContainingCountryCountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullAddres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("PhoneNumbersListId")
                        .HasColumnType("int");

                    b.Property<int?>("RelationshipTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("GenderId");

                    b.HasIndex("PhoneNumbersListId");

                    b.HasIndex("RelationshipTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CustomerPhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumberId")
                        .HasColumnType("int");

                    b.Property<int>("PhoneTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PhoneNumberId");

                    b.HasIndex("PhoneTypeId");

                    b.ToTable("CustomerPhoneNumbers");
                });

            modelBuilder.Entity("CustomersRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("EndCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RelationshipTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("StartCustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EndCustomerId");

                    b.HasIndex("RelationshipTypeId");

                    b.HasIndex("StartCustomerId");

                    b.ToTable("CustomersRelationships");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<bool>("IsDiscounted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.PhoneNumbersList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int?>("PhoneTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhoneTypeId");

                    b.ToTable("PhoneNumbersLists");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.PhoneType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PhoneTypes");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<bool>("Discount")
                        .HasColumnType("bit");

                    b.Property<double?>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("RealizationPrice")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("ShelfLife")
                        .HasColumnType("time");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategorys");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.RelationshipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RelationshipTypes");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactFullName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Fax")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.HasOne("Country", "ContainingCountry")
                        .WithMany()
                        .HasForeignKey("ContainingCountryCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContainingCountry");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("TradingWebAppFinalProject.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("TradingWebAppFinalProject.Models.PhoneNumbersList", "PhoneNumbersList")
                        .WithMany()
                        .HasForeignKey("PhoneNumbersListId");

                    b.HasOne("TradingWebAppFinalProject.Models.RelationshipType", "RelationshipType")
                        .WithMany()
                        .HasForeignKey("RelationshipTypeId");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Gender");

                    b.Navigation("PhoneNumbersList");

                    b.Navigation("RelationshipType");
                });

            modelBuilder.Entity("CustomerPhoneNumber", b =>
                {
                    b.HasOne("Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradingWebAppFinalProject.Models.PhoneNumbersList", "PhoneNumber")
                        .WithMany()
                        .HasForeignKey("PhoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradingWebAppFinalProject.Models.PhoneType", "PhoneType")
                        .WithMany()
                        .HasForeignKey("PhoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("PhoneNumber");

                    b.Navigation("PhoneType");
                });

            modelBuilder.Entity("CustomersRelationship", b =>
                {
                    b.HasOne("Customer", "EndCustomer")
                        .WithMany()
                        .HasForeignKey("EndCustomerId");

                    b.HasOne("TradingWebAppFinalProject.Models.RelationshipType", "RelationshipType")
                        .WithMany()
                        .HasForeignKey("RelationshipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Customer", "StartCustomer")
                        .WithMany()
                        .HasForeignKey("StartCustomerId");

                    b.Navigation("EndCustomer");

                    b.Navigation("RelationshipType");

                    b.Navigation("StartCustomer");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.HasOne("Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradingWebAppFinalProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.PhoneNumbersList", b =>
                {
                    b.HasOne("TradingWebAppFinalProject.Models.PhoneType", "PhoneType")
                        .WithMany()
                        .HasForeignKey("PhoneTypeId");

                    b.Navigation("PhoneType");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Product", b =>
                {
                    b.HasOne("TradingWebAppFinalProject.Models.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TradingWebAppFinalProject.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("TradingWebAppFinalProject.Models.Supplier", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
