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
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.Property<bool>("Verified")
                        .HasColumnType("tinyint(1)");

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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

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

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

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

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DistancePriceList", b =>
                {
                    b.Property<int>("DistancePriceListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DistancePriceListId"));

                    b.Property<float>("MaxRange")
                        .HasColumnType("float");

                    b.Property<float>("MinRange")
                        .HasColumnType("float");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("DistancePriceListId");

                    b.ToTable("DistancePriceList");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("FeedbackId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.FishProfile", b =>
                {
                    b.Property<int>("FishProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("FishProfileId"));

                    b.Property<string>("Certificate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("KoiFishId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Weight")
                        .HasColumnType("float");

                    b.HasKey("FishProfileId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("KoiFishId");

                    b.ToTable("FishProfile");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.HealthStatus", b =>
                {
                    b.Property<int>("HealthStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("HealthStatusId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderDetailsId")
                        .HasColumnType("int");

                    b.Property<float>("OxygenLevel")
                        .HasColumnType("float");

                    b.Property<float>("PHLevel")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("HealthStatusId");

                    b.HasIndex("OrderDetailsId");

                    b.ToTable("HealthStatus");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.KoiFish", b =>
                {
                    b.Property<int>("KoiFishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("KoiFishId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FishType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("KoiFishId");

                    b.ToTable("KoiFish");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.LogTransport", b =>
                {
                    b.Property<int>("LogTransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LogTransportId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("LogTransportId");

                    b.HasIndex("TransportId");

                    b.ToTable("LogTransport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderDetailsId"));

                    b.Property<int>("FishProfileId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("FishProfileId")
                        .IsUnique();

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
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("int");

                    b.Property<int>("DistancePriceListId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RecipientAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecipientPhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SenderPhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double");

                    b.Property<double>("TotalWeight")
                        .HasColumnType("double");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WeightPriceListId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DistancePriceListId");

                    b.HasIndex("TransportId");

                    b.HasIndex("WeightPriceListId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnType("longtext");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

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

                    b.Property<int>("HealthCareStaffId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("TransportId");

                    b.HasIndex("DeliveryStaffId")
                        .IsUnique();

                    b.HasIndex("StaffId");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Verification", b =>
                {
                    b.Property<int>("VerificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("VerificationId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("VerificationId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Verification");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.WeightPriceList", b =>
                {
                    b.Property<int>("WeightPriceListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("WeightPriceListId"));

                    b.Property<float>("MaxRange")
                        .HasColumnType("float");

                    b.Property<float>("MinRange")
                        .HasColumnType("float");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("WeightPriceListId");

                    b.ToTable("WeightPriceList");
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

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Feedback", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Customer", "Customer")
                        .WithMany("Feedback")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.Orders", "Orders")
                        .WithOne("Feedback")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Feedback", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.FishProfile", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Customer", "Customer")
                        .WithMany("FishProfiles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.KoiFish", "KoiFish")
                        .WithMany("FishProfile")
                        .HasForeignKey("KoiFishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("KoiFish");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.HealthStatus", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.OrderDetails", "OrderDetails")
                        .WithMany("HealthStatus")
                        .HasForeignKey("OrderDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.LogTransport", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Customer", "Customer")
                        .WithMany("LogTransport")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.Transport", "Transport")
                        .WithMany("LogTransports")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.FishProfile", "FishProfile")
                        .WithOne("OrderDetails")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.OrderDetails", "FishProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FishProfile");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Orders", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.DistancePriceList", "DistancePriceList")
                        .WithMany("Orders")
                        .HasForeignKey("DistancePriceListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.Transport", "Transport")
                        .WithMany("Orders")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KDOS_Web_API.Models.Domains.WeightPriceList", "WeightPriceList")
                        .WithMany("Orders")
                        .HasForeignKey("WeightPriceListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("DistancePriceList");

                    b.Navigation("Transport");

                    b.Navigation("WeightPriceList");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Payment", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Orders", "Orders")
                        .WithOne("Payment")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");
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

                    b.HasOne("KDOS_Web_API.Models.Domains.Staff", "Staff")
                        .WithMany("Transports")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryStaff");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Verification", b =>
                {
                    b.HasOne("KDOS_Web_API.Models.Domains.Account", "Account")
                        .WithOne("Verification")
                        .HasForeignKey("KDOS_Web_API.Models.Domains.Verification", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Account", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("DeliveryStaff");

                    b.Navigation("Staff");

                    b.Navigation("Verification");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Customer", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("FishProfiles");

                    b.Navigation("LogTransport");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DeliveryStaff", b =>
                {
                    b.Navigation("Transport");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.DistancePriceList", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.FishProfile", b =>
                {
                    b.Navigation("OrderDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.KoiFish", b =>
                {
                    b.Navigation("FishProfile");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.OrderDetails", b =>
                {
                    b.Navigation("HealthStatus");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Orders", b =>
                {
                    b.Navigation("Feedback")
                        .IsRequired();

                    b.Navigation("OrderDetails");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Staff", b =>
                {
                    b.Navigation("Transports");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.Transport", b =>
                {
                    b.Navigation("LogTransports");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KDOS_Web_API.Models.Domains.WeightPriceList", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
