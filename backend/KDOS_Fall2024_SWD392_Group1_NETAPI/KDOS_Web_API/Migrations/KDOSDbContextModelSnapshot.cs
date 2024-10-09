﻿// <auto-generated />
using System;
using KDOS_Web_API.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KDOS_Web_API.Migrations
{
    [DbContext(typeof(KDOSDbContext))]
    partial class KDOSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<bool>("Banned")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CustomerId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DeliveryStaff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StaffId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("DeliveryStaff");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.KoiFish", b =>
                {
                    b.Property<int>("KoiFishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("KoiFishId"));

                    b.Property<string>("FishType")
                        .HasColumnType("longtext");

                    b.Property<string>("HealthStatus")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderDetailsId")
                        .HasColumnType("int");

                    b.HasKey("KoiFishId");

                    b.HasIndex("OrderDetailsId");

                    b.ToTable("KoiFish");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderDetailsId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("float");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryNote")
                        .HasColumnType("longtext");

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RecipientAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientName")
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientPhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double");

                    b.Property<double>("TotalWeight")
                        .HasColumnType("double");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TransportId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StaffId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Transport", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TransportId"));

                    b.Property<int>("DeliveryStaffId")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TransportId");

                    b.HasIndex("DeliveryStaffId")
                        .IsUnique();

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Customer", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Customer", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DeliveryStaff", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Account", "Account")
                        .WithOne("DeliveryStaff")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.DeliveryStaff", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.KoiFish", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.OrderDetails", "OrderDetails")
                        .WithMany("KoiFish")
                        .HasForeignKey("OrderDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Orders", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.Transport", "Transport")
                        .WithMany("Orders")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Staff", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Account", "Account")
                        .WithOne("Staff")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Staff", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Transport", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.DeliveryStaff", "DeliveryStaff")
                        .WithOne("Transport")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Transport", "DeliveryStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryStaff");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Account", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("DeliveryStaff");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DeliveryStaff", b =>
                {
                    b.Navigation("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.Navigation("KoiFish");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Transport", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
