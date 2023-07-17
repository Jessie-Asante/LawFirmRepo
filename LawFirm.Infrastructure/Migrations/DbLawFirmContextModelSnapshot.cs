﻿// <auto-generated />
using System;
using LawFirm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LawFirm.Infrastructure.Migrations
{
    [DbContext(typeof(DbLawFirmContext))]
    partial class DbLawFirmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LawFirm.Domain.Models.TblAboutTag", b =>
                {
                    b.Property<int>("AbtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbtId"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbtId");

                    b.ToTable("TblAboutTags");
                });

            modelBuilder.Entity("LawFirm.Domain.Models.TblBookingTag", b =>
                {
                    b.Property<int>("BktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BktId"));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<DateTime>("dtpDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BktId");

                    b.ToTable("TblBookingTags");
                });

            modelBuilder.Entity("LawFirm.Domain.Models.TblHomeTag", b =>
                {
                    b.Property<int>("HmtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HmtId"));

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageHeader")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HmtId");

                    b.ToTable("TblHomeTags");
                });

            modelBuilder.Entity("LawFirm.Domain.Models.TblReasonsTag", b =>
                {
                    b.Property<int>("RstId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RstId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RstId");

                    b.ToTable("TblReasonsTags");
                });

            modelBuilder.Entity("LawFirm.Domain.Models.TblServiceTag", b =>
                {
                    b.Property<int>("SvtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SvtId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SvtId");

                    b.ToTable("TblServiceTags");
                });

            modelBuilder.Entity("LawFirm.Domain.Models.TblUserBooking", b =>
                {
                    b.Property<int>("UsbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsbId"));

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobNox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsbId");

                    b.ToTable("TblUserBookings");
                });
#pragma warning restore 612, 618
        }
    }
}
