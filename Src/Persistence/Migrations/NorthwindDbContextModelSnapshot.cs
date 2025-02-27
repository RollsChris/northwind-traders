﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.Persistence;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Northwind.Persistence.Migrations
{
    [DbContext(typeof(NorthwindDbContext))]
    partial class NorthwindDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Northwind.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("CategoryID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("bytea");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("EmployeeID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Extension")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("bytea");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("EmployeeID");

                    b.Property<string>("TerritoryId")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("TerritoryID");

                    b.HasKey("EmployeeId", "TerritoryId");

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("OrderID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("CustomerID");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("ShipName")
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int?>("ShipVia")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("OrderID");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("ProductID");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Order Details", (string)null);
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ProductID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("integer")
                        .HasColumnName("SupplierID");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnType("integer")
                        .HasColumnName("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("RegionId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ShipperID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ShipperId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("SupplierID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("ContactName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("HomePage")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Territory", b =>
                {
                    b.Property<string>("TerritoryId")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("TerritoryID");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer")
                        .HasColumnName("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("TerritoryId");

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Employee", "Manager")
                        .WithMany("DirectReports")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.EmployeeTerritory", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeeTerritories_Employees");

                    b.HasOne("Northwind.Domain.Entities.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeeTerritories_Territories");

                    b.Navigation("Employee");

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Order", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Northwind.Domain.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Northwind.Domain.Entities.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Orders_Shippers");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Details_Orders");

                    b.HasOne("Northwind.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Details_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Product", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Northwind.Domain.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Territory", b =>
                {
                    b.HasOne("Northwind.Domain.Entities.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .IsRequired()
                        .HasConstraintName("FK_Territories_Region");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Employee", b =>
                {
                    b.Navigation("DirectReports");

                    b.Navigation("EmployeeTerritories");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Northwind.Domain.Entities.Territory", b =>
                {
                    b.Navigation("EmployeeTerritories");
                });
#pragma warning restore 612, 618
        }
    }
}
