﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelExpensesAPI.Data;

#nullable disable

namespace TravelExpensesAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TravelExpensesAPI.Models.AdditionalCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AdditionalCost");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountBreakfasts")
                        .HasColumnType("int");

                    b.Property<int>("AmountOtherMeals")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndAddressId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<int>("StartAddressId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("TravelBeginDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("TravelBeginTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("TravelEndDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("TravelEndTime")
                        .HasColumnType("time");

                    b.Property<int>("TravelReasonId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EndAddressId")
                        .IsUnique();

                    b.HasIndex("StartAddressId")
                        .IsUnique();

                    b.HasIndex("TravelReasonId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Approval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("UserId");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.BankDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankInstitution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BankDetails");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdditionalCostId")
                        .HasColumnType("int");

                    b.Property<byte[]>("File")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalCostId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.TravelReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<double>("BreakfastAllowance")
                        .HasColumnType("float");

                    b.Property<double>("DayRate")
                        .HasColumnType("float");

                    b.Property<double>("HoursArrivalDay")
                        .HasColumnType("float");

                    b.Property<double>("HoursDepartureDay")
                        .HasColumnType("float");

                    b.Property<bool>("Internal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDirty")
                        .HasColumnType("bit");

                    b.Property<double>("KilometerAllowance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OtherMealAllowance")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TravelReasons");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Application", b =>
                {
                    b.HasOne("TravelExpensesAPI.Models.Address", "EndAddress")
                        .WithOne()
                        .HasForeignKey("TravelExpensesAPI.Models.Application", "EndAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TravelExpensesAPI.Models.Address", "StartAddress")
                        .WithOne()
                        .HasForeignKey("TravelExpensesAPI.Models.Application", "StartAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TravelExpensesAPI.Models.TravelReason", "TravelReason")
                        .WithMany()
                        .HasForeignKey("TravelReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelExpensesAPI.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EndAddress");

                    b.Navigation("StartAddress");

                    b.Navigation("TravelReason");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Approval", b =>
                {
                    b.HasOne("TravelExpensesAPI.Models.Application", null)
                        .WithMany("Approvals")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("TravelExpensesAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.BankDetails", b =>
                {
                    b.HasOne("TravelExpensesAPI.Models.User", null)
                        .WithOne("BankDetails")
                        .HasForeignKey("TravelExpensesAPI.Models.BankDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Document", b =>
                {
                    b.HasOne("TravelExpensesAPI.Models.AdditionalCost", "AdditionalCost")
                        .WithMany("Documents")
                        .HasForeignKey("AdditionalCostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdditionalCost");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.AdditionalCost", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.Application", b =>
                {
                    b.Navigation("Approvals");
                });

            modelBuilder.Entity("TravelExpensesAPI.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("BankDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
