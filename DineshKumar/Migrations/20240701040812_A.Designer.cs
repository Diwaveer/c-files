﻿// <auto-generated />
using DineshKumar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DineshKumar.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240701040812_A")]
    partial class A
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DineshKumar.Models.College", b =>
                {
                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Masterdepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.ToTable("StaffDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
