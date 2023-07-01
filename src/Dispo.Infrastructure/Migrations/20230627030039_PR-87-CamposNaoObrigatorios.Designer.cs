﻿// <auto-generated />
using System;
using Dispo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dispo.Infrastructure.Migrations
{
    [DbContext(typeof(DispoContext))]
    [Migration("20230627030039_PR-87-CamposNaoObrigatorios")]
    partial class PR87CamposNaoObrigatorios
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dispo.Domain.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Password");

                    b.Property<long>("RoleId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("UserId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Adress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("AdditionalInfo");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("VARCHAR(9)")
                        .HasColumnName("CEP");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Country");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("District");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("VARCHAR(3)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.ToTable("Adresses", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AdressId")
                        .HasColumnType("BIGINT");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("VARCHAR(18)")
                        .HasColumnName("Cnpj");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Companies", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Manufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Logo")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("Logo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Movement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("BIGINT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<int>("Quantity")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER")
                        .HasColumnName("Quantity");

                    b.Property<short>("Type")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Type");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WarehouseId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("WarehouseId");

                    b.HasIndex("WarehouseId1")
                        .IsUnique()
                        .HasFilter("[WarehouseId1] IS NOT NULL");

                    b.ToTable("Movements", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Description");

                    b.Property<long>("ProductId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("PurchaseOrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER")
                        .HasColumnName("Quantity");

                    b.Property<decimal>("TotalPrice")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<short>("Category")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Category");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Code");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpirationDate");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("Image");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ManufacturingDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Name");

                    b.Property<long>("ProductDimensionId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PurchasePrice")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("PurchasePrice");

                    b.Property<decimal>("SalePrice")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("SalePrice");

                    b.Property<short>("UnitOfMeasurement")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("UnitOfMeasurement");

                    b.HasKey("Id");

                    b.HasIndex("ProductDimensionId")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductDimension", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Depth")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("Depth");

                    b.Property<decimal>("Height")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("Height");

                    b.Property<decimal>("Weight")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("Weight");

                    b.Property<decimal>("Width")
                        .HasMaxLength(120)
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("Width");

                    b.HasKey("Id");

                    b.ToTable("ProductDimensions", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductManufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("ProductId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductManufacturers", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductMovement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("MovimentId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("ProductId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("MovimentId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMovements", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductWarehouseQuantity", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("DECIMAL(10, 2)")
                        .HasColumnName("Quantity");

                    b.HasKey("ProductId", "WarehouseId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("WarehouseId")
                        .IsUnique();

                    b.HasIndex("ProductId", "WarehouseId")
                        .IsUnique();

                    b.ToTable("ProductWarehouseQuantities", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<short>("NotificationType")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("NotificationType");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("Number");

                    b.Property<short>("PaymentMethod")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("PaymentMethod");

                    b.Property<long>("ShippingId")
                        .HasColumnType("bigint");

                    b.Property<short>("Status")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Status");

                    b.Property<long>("SupplierId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("PurchaseOrders", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.PurchaseOrderAttachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte[]>("Attatchment")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Attatchment");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationDate");

                    b.Property<DateTime>("ModifieldDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ModifieldDate");

                    b.Property<long>("PurchaseOrderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderAttachments", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Name");

                    b.Property<short>("Type")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Shipping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EstimatedDeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<long>("PurchaseOrderId")
                        .HasColumnType("bigint");

                    b.Property<string>("ShippingPrice")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderId")
                        .IsUnique();

                    b.ToTable("Shippings", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Supplier", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AdressId")
                        .HasColumnType("BIGINT");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("VARCHAR(18)")
                        .HasColumnName("Cnpj");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("VARCHAR(120)")
                        .HasColumnName("ContactName");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("ContactTitle");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("VARCHAR(16)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<long>("AdressId")
                        .HasColumnType("BIGINT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("VARCHAR(18)")
                        .HasColumnName("Cpf");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)")
                        .HasColumnName("LastName");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("VARCHAR(16)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.HasIndex("CompanyId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Warehouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AdressId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.HasIndex("CompanyId");

                    b.ToTable("Warehouses", (string)null);
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Account", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("Dispo.Domain.Entities.Account", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Company", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Adress", "Adress")
                        .WithOne("Company")
                        .HasForeignKey("Dispo.Domain.Entities.Company", "AdressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Movement", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Account", "Account")
                        .WithMany("Movements")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Movements")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Warehouse", null)
                        .WithOne("Movement")
                        .HasForeignKey("Dispo.Domain.Entities.Movement", "WarehouseId1");

                    b.Navigation("Account");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Order", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany("Orders")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Product", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.ProductDimension", "ProductDimension")
                        .WithOne("Product")
                        .HasForeignKey("Dispo.Domain.Entities.Product", "ProductDimensionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductDimension");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductManufacturer", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Manufacturer", "Manufacturer")
                        .WithMany("ProductManufacturers")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Product", "Product")
                        .WithMany("ProductManufacturers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductMovement", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Movement", "Movement")
                        .WithMany("ProductMoviments")
                        .HasForeignKey("MovimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Product", "Product")
                        .WithMany("ProductMoviments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movement");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductWarehouseQuantity", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Product", "Product")
                        .WithOne("ProductWarehouseQuantity")
                        .HasForeignKey("Dispo.Domain.Entities.ProductWarehouseQuantity", "ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Warehouse", "Warehouse")
                        .WithOne("ProductWarehouseQuantity")
                        .HasForeignKey("Dispo.Domain.Entities.ProductWarehouseQuantity", "WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.PurchaseOrder", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Supplier", "Supplier")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.PurchaseOrderAttachment", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderAttachments")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Shipping", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithOne("Shipping")
                        .HasForeignKey("Dispo.Domain.Entities.Shipping", "PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Supplier", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Adress", "Adress")
                        .WithOne("Supplier")
                        .HasForeignKey("Dispo.Domain.Entities.Supplier", "AdressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.User", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Adress", "Adress")
                        .WithOne("User")
                        .HasForeignKey("Dispo.Domain.Entities.User", "AdressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Warehouse", b =>
                {
                    b.HasOne("Dispo.Domain.Entities.Adress", "Adress")
                        .WithOne("Warehouse")
                        .HasForeignKey("Dispo.Domain.Entities.Warehouse", "AdressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Dispo.Domain.Entities.Company", "Company")
                        .WithMany("Warehouses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Account", b =>
                {
                    b.Navigation("Movements");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Adress", b =>
                {
                    b.Navigation("Company")
                        .IsRequired();

                    b.Navigation("Supplier")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();

                    b.Navigation("Warehouse")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Company", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Manufacturer", b =>
                {
                    b.Navigation("ProductManufacturers");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Movement", b =>
                {
                    b.Navigation("ProductMoviments");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Product", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ProductManufacturers");

                    b.Navigation("ProductMoviments");

                    b.Navigation("ProductWarehouseQuantity")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Domain.Entities.ProductDimension", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PurchaseOrderAttachments");

                    b.Navigation("Shipping")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("Dispo.Domain.Entities.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Movement")
                        .IsRequired();

                    b.Navigation("Movements");

                    b.Navigation("ProductWarehouseQuantity")
                        .IsRequired();

                    b.Navigation("PurchaseOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
