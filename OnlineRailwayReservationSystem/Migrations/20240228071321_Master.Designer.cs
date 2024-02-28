﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineRailwayReservationSystem.Models;

#nullable disable

namespace OnlineRailwayReservationSystem.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20240228071321_Master")]
    partial class Master
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.CancellationFees", b =>
                {
                    b.Property<int>("CancellationFees_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CancellationFees_Id"), 1L, 1);

                    b.Property<int>("Cancellation_12Hours")
                        .HasColumnType("int");

                    b.Property<int>("Cancellation_1Hours")
                        .HasColumnType("int");

                    b.Property<int>("Cancellation_24Hours")
                        .HasColumnType("int");

                    b.HasKey("CancellationFees_Id");

                    b.ToTable("tbl_CancellationFees");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.FareRule", b =>
                {
                    b.Property<int>("Fare_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fare_Id"), 1L, 1);

                    b.Property<string>("Coach_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Distance_From")
                        .HasColumnType("int");

                    b.Property<int>("Distance_To")
                        .HasColumnType("int");

                    b.Property<int>("Ticket_Amount")
                        .HasColumnType("int");

                    b.HasKey("Fare_Id");

                    b.ToTable("tbl_FareRule");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.ReservationFees", b =>
                {
                    b.Property<int>("ReservationFees_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationFees_Id"), 1L, 1);

                    b.Property<string>("Coach_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reservation_Fees")
                        .HasColumnType("int");

                    b.Property<int>("Super_Fast_Fees")
                        .HasColumnType("int");

                    b.HasKey("ReservationFees_Id");

                    b.ToTable("tbl_ReservationFees");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.StationMaster", b =>
                {
                    b.Property<int>("Station_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Station_Id"), 1L, 1);

                    b.Property<string>("Station_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Station_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Station_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Station_Id");

                    b.ToTable("tbl_StationMaster");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.TrainMaster", b =>
                {
                    b.Property<int>("Train_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Train_Id"), 1L, 1);

                    b.Property<int>("Coach_A1")
                        .HasColumnType("int");

                    b.Property<int>("Coach_A2")
                        .HasColumnType("int");

                    b.Property<int>("Coach_A3")
                        .HasColumnType("int");

                    b.Property<int>("Coach_GN")
                        .HasColumnType("int");

                    b.Property<int>("Coach_SL")
                        .HasColumnType("int");

                    b.Property<string>("Schedule_Fri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Mon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Sat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Sun")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Thu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Tue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule_Wed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Train_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Train_No")
                        .HasColumnType("int");

                    b.Property<string>("Train_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Train_Id");

                    b.ToTable("tbl_TrainMaster");
                });
#pragma warning restore 612, 618
        }
    }
}