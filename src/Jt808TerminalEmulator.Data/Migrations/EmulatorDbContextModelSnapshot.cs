﻿// <auto-generated />
using System;
using Jt808TerminalEmulator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Jt808TerminalEmulator.Data.Migrations
{
    [DbContext(typeof(EmulatorDbContext))]
    partial class EmulatorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateUserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<decimal>("Distance")
                        .HasColumnType("numeric");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("LocationCount")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<double>("Speed")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LocationEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateUserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<string>("LineId")
                        .HasColumnType("character varying(36)");

                    b.Property<double>("Logintude")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.TaskEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateUserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.TerminalEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreateUserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

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

                    b.Navigation("Line");
                });

            modelBuilder.Entity("Jt808TerminalEmulator.Data.Entity.LineEntity", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
