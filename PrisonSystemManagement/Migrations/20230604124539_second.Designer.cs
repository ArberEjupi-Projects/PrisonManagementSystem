﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrisonSystemManagement.Data;

#nullable disable

namespace PrisonSystemManagement.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230604124539_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PrisonSystemManagement.Model.Drejtori", b =>
                {
                    b.Property<int>("DrejtoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrejtoriID"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gjinia")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qyteti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rruga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SektoriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zipkodi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrejtoriID");

                    b.ToTable("Drejtori");
                });

            modelBuilder.Entity("PrisonSystemManagement.Model.Infiermeria", b =>
                {
                    b.Property<int>("InfiermeriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfiermeriaID"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kapaciteti")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("SektoriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("InfiermeriaID");

                    b.ToTable("Infiermeria");
                });

            modelBuilder.Entity("PrisonSystemManagement.Model.Sektori", b =>
                {
                    b.Property<int>("SektoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SektoriID"), 1L, 1);

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmriSektorit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("SektoriID");

                    b.ToTable("Sektori");
                });
#pragma warning restore 612, 618
        }
    }
}