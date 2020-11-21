﻿// <auto-generated />
using System;
using Jt808TerminalEmulator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jt808TerminalEmulator.Data.Migrations
{
    [DbContext(typeof(EmulatorDbContext))]
    [Migration("20201020150543_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LocationCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<double>("Speed")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LocationEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<string>("LineId")
                        .HasColumnType("varchar(36)");

                    b.Property<double>("Logintude")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.TerminalEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LicensePlate")
                        .HasColumnType("text");

                    b.Property<string>("Sim")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Terminal");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LocationEntity", b =>
                {
                    b.HasOne("Jt808TerminalEmulator.Data.Entity.LineEntity", "Line")
                        .WithMany("Locations")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
