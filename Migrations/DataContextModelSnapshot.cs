﻿// <auto-generated />
using System;
using AfComputerBuilder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AfComputerBuilder.Migrations
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

            modelBuilder.Entity("AfComputerBuilder.Models.cpuComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("baseWatts")
                        .HasColumnType("int");

                    b.Property<string>("cashe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("includesCooler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maxMemoryChannels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maxMemorySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maxTurbo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxWatts")
                        .HasColumnType("int");

                    b.Property<string>("memoryTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("processorGraphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("processorNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("releaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("threds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalCores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalL2Cache")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("cpuComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.cpuCoolerComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("CPUSocket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fanRPM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiseLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("cpuCoolerComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.GpuComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("DirectX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("baseClock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("boostClock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("busInterface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memorySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("outputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("slotWidth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("watts")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("GpuComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.hardDiskComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("capacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("interFace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("readSpead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rotationRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("watts")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("hardDiskComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.motherBoardComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expansionSlots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("m2Slots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memoryMaximumCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memoryMaximumChannels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memoryMaximumSpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memorySlotProtcol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motherBoardImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("releaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sataSlots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usbSlots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("watts")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("motherBoardComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.psuComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("efficiencyRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modularity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("powerOutput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("wattage")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("psuComponent");
                });

            modelBuilder.Entity("AfComputerBuilder.Models.ramComponent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Watts")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ramComponent");
                });
#pragma warning restore 612, 618
        }
    }
}