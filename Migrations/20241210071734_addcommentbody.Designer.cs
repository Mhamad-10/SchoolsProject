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
    [Migration("20241210071734_addcommentbody")]
    partial class addcommentbody
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

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.HasIndex("GovernorateId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("SchoolsProject.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<int>("NumberOfRatings")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<string>("SchoolImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolId");

                    b.HasIndex("RegionId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("SchoolsProject.Models.SchoolComment", b =>
                {
                    b.Property<int>("SchoolCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolCommentId"));

                    b.Property<string>("CommentBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("SchoolCommentId");

                    b.HasIndex("SchoolId");

                    b.ToTable("SchoolComments");
                });

            modelBuilder.Entity("SchoolsProject.Models.Region", b =>
                {
                    b.HasOne("SchoolsProject.Models.Governorate", "Governorate")
                        .WithMany()
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("SchoolsProject.Models.School", b =>
                {
                    b.HasOne("SchoolsProject.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("SchoolsProject.Models.SchoolComment", b =>
                {
                    b.HasOne("SchoolsProject.Models.School", "School")
                        .WithMany("Comments")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("SchoolsProject.Models.School", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
