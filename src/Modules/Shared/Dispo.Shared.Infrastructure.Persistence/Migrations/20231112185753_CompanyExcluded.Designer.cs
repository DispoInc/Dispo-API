﻿// <auto-generated />
using System;
using Dispo.Shared.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dispo.Infrastructure.Migrations
{
    [DbContext(typeof(DispoContext))]
    [Migration("20231112185753_CompanyExcluded")]
    partial class CompanyExcluded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

                    b.Property<long>("CompanyIdByHub")
                        .HasColumnType("BIGINT")
                        .HasColumnName("CompanyIdByHub");

                    b.Property<long?>("CurrentWarehouseId")
                        .HasColumnType("BIGINT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Email");

                    b.Property<DateTime>("LastLicenceCheck")
                        .HasColumnType("datetime2")
                        .HasColumnName("LastLicenceCheck");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Password");

                    b.Property<long>("RoleId")
                        .HasColumnType("BIGINT");

                    b.Property<long?>("UserId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("CurrentWarehouseId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("AdditionalInfo");

                    b.Property<string>("CEP")
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
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("District");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("VARCHAR(3)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Batch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpirationDate");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Key");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ManufacturingDate");

                    b.Property<long>("OrderId")
                        .HasColumnType("BIGINT");

                    b.Property<int>("ProductQuantity")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER")
                        .HasColumnName("ProductQuantity");

                    b.Property<int>("QuantityPerBatch")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER")
                        .HasColumnName("QuantityPerBatch");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Batches", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.BatchMovement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BatchId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("MovementId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("MovementId");

                    b.ToTable("BatchMovements", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Manufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

                    b.Property<byte[]>("Logo")
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

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Movement", b =>
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
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Movements", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Description");

                    b.Property<long>("ProductId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("PurchaseOrderId")
                        .HasColumnType("BIGINT");

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

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

                    b.Property<short>("Category")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("VARCHAR(220)")
                        .HasColumnName("Description");

                    b.Property<byte[]>("Image")
                        .HasColumnType("image")
                        .HasColumnName("Image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("Name");

                    b.Property<long?>("ProductDimensionId")
                        .HasColumnType("BIGINT");

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
                        .IsUnique()
                        .HasFilter("[ProductDimensionId] IS NOT NULL");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.ProductDimension", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

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

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.ProductManufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

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

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

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

                    b.Property<short>("Status")
                        .HasMaxLength(120)
                        .HasColumnType("SMALLINT")
                        .HasColumnName("Status");

                    b.Property<long>("SupplierId")
                        .HasColumnType("BIGINT");

                    b.Property<long?>("WarehouseId")
                        .IsRequired()
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("PurchaseOrders", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.PurchaseOrderAttachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

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
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderAttachments", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Key");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Key = "manager",
                            Name = "Gerente"
                        },
                        new
                        {
                            Id = 2L,
                            Key = "purchasingManager",
                            Name = "Gerente de compras"
                        },
                        new
                        {
                            Id = 3L,
                            Key = "warehouseOperator",
                            Name = "Operador de depósito"
                        });
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Shipping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EstimatedDeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<long>("PurchaseOrderId")
                        .HasColumnType("BIGINT");

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

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Supplier", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("BIGINT");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

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

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("BIGINT");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

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

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Warehouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("BIGINT");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Ativo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Warehouses", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.WarehouseAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("BIGINT");

                    b.Property<long>("WarehouseId")
                        .HasColumnType("BIGINT");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseAccounts", (string)null);
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Account", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Warehouse", "CurrentWarehouse")
                        .WithMany()
                        .HasForeignKey("CurrentWarehouseId");

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.Account", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CurrentWarehouse");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Batch", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Order", "Order")
                        .WithMany("Batches")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.BatchMovement", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Batch", "Batch")
                        .WithMany("BatchMovements")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Movement", "Movement")
                        .WithMany("BatchMovements")
                        .HasForeignKey("MovementId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("Movement");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Movement", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Account", "Account")
                        .WithMany("Movements")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Movements")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Order", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany("Orders")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Product", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.ProductDimension", "ProductDimension")
                        .WithOne("Product")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.Product", "ProductDimensionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductDimension");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.ProductManufacturer", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Manufacturer", "Manufacturer")
                        .WithMany("ProductManufacturers")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Product", "Product")
                        .WithMany("ProductManufacturers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Supplier", "Supplier")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.PurchaseOrderAttachment", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderAttachments")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Shipping", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithOne("Shipping")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.Shipping", "PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Supplier", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Address", "Address")
                        .WithOne("Supplier")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.Supplier", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.User", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Address", "Address")
                        .WithOne("User")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.User", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Warehouse", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Address", "Address")
                        .WithOne("Warehouse")
                        .HasForeignKey("Dispo.Shared.Core.Domain.Entities.Warehouse", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.WarehouseAccount", b =>
                {
                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Account", "Account")
                        .WithMany("WarehouseAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Dispo.Shared.Core.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("WarehouseAccounts")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Account", b =>
                {
                    b.Navigation("Movements");

                    b.Navigation("WarehouseAccounts");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Address", b =>
                {
                    b.Navigation("Supplier")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();

                    b.Navigation("Warehouse")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Batch", b =>
                {
                    b.Navigation("BatchMovements");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Manufacturer", b =>
                {
                    b.Navigation("ProductManufacturers");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Movement", b =>
                {
                    b.Navigation("BatchMovements");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Order", b =>
                {
                    b.Navigation("Batches");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Product", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ProductManufacturers");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.ProductDimension", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PurchaseOrderAttachments");

                    b.Navigation("Shipping")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });

            modelBuilder.Entity("Dispo.Shared.Core.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Movements");

                    b.Navigation("PurchaseOrders");

                    b.Navigation("WarehouseAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
