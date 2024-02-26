﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineRailwayReservationSystem.Models;

#nullable disable

namespace OnlineRailwayReservationSystem.Migrations
{
    [DbContext(typeof(myContext))]
    partial class myContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
#pragma warning restore 612, 618
        }
    }
}