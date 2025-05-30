﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolsProject.Data;

#nullable disable

namespace SchoolsProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241114090040_intialMig")]
    partial class intialMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolsProject.Models.Governorate", b =>
                {
                    b.Property<int>("GovernorateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GovernorateId"));

                    b.Property<string>("GovernorateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GovernorateId");

                    b.ToTable("Governorates");
                });

            modelBuilder.Entity("SchoolsProject.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"));

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("SchoolsProject.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<string>("SchoolImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}
