﻿// <auto-generated />
using System;
using FramesBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FramesBlazor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220312081118_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("FramesBlazor.Models.AdminBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastMonthBill")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastMonthLeft")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AdminBills");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminBillFrameType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminBillId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FrameName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FrameRate")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminBillId");

                    b.ToTable("AdminBillFrameTypes");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminFramesIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("NoOfFrames")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AdminFramesIns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 3, 10, 10, 21, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 87
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 3, 6, 16, 47, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 94
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 3, 1, 11, 46, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 86
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 3, 6, 11, 4, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 61
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 3, 9, 13, 53, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 91
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2022, 3, 9, 10, 29, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 88
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2022, 3, 8, 16, 11, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 51
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2022, 3, 3, 13, 14, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 86
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 3, 4, 14, 31, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 53
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2022, 3, 8, 13, 39, 0, 0, DateTimeKind.Unspecified),
                            NoOfFrames = 52
                        });
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminFramesOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AdminFramesOuts");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminFramesOutNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminFramesOutId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NoOfFrames")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminFramesOutId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("AdminFramesOutNumbers");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AdminPayments");
                });

            modelBuilder.Entity("FramesBlazor.Models.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AdminPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WorkerPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminPrice = 17m,
                            ItemName = "Item1",
                            WorkerPrice = 12.5m
                        },
                        new
                        {
                            Id = 2,
                            AdminPrice = 9m,
                            ItemName = "Item2",
                            WorkerPrice = 7.5m
                        },
                        new
                        {
                            Id = 3,
                            AdminPrice = 13m,
                            ItemName = "Item3",
                            WorkerPrice = 9m
                        });
                });

            modelBuilder.Entity("FramesBlazor.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Logan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jean"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Scott"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kitty"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Storm"
                        });
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Cleared")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerBills");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerBillFrameTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FrameName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FrameRate")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkerBillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkerBillId");

                    b.ToTable("WorkerBillFrameTypes");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("TEXT");

                    b.Property<int>("NoOfFrames")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerFramesIns");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerFramesOuts");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesOutNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NoOfFrames")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkerFramesOutId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeId");

                    b.HasIndex("WorkerFramesOutId");

                    b.ToTable("WorkerFramesOutNumbers");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WorkerPayments");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminBillFrameType", b =>
                {
                    b.HasOne("FramesBlazor.Models.AdminBill", "AdminBill")
                        .WithMany("AdminBillFrameTypes")
                        .HasForeignKey("AdminBillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminBill");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminFramesOutNumber", b =>
                {
                    b.HasOne("FramesBlazor.Models.AdminFramesOut", "AdminFramesOut")
                        .WithMany("AdminFramesOutNumbers")
                        .HasForeignKey("AdminFramesOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FramesBlazor.Models.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminFramesOut");

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerBill", b =>
                {
                    b.HasOne("FramesBlazor.Models.Worker", "Worker")
                        .WithMany("WorkerBills")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerBillFrameTypes", b =>
                {
                    b.HasOne("FramesBlazor.Models.WorkerBill", "WorkerBill")
                        .WithMany("WorkerBillFrameTypes")
                        .HasForeignKey("WorkerBillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkerBill");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesIn", b =>
                {
                    b.HasOne("FramesBlazor.Models.Worker", "Worker")
                        .WithMany("WorkerFramesIn")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesOut", b =>
                {
                    b.HasOne("FramesBlazor.Models.Worker", "Worker")
                        .WithMany("WorkerFramesOut")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesOutNumber", b =>
                {
                    b.HasOne("FramesBlazor.Models.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FramesBlazor.Models.WorkerFramesOut", "WorkerFramesOut")
                        .WithMany("WorkerFramesOutNumbers")
                        .HasForeignKey("WorkerFramesOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");

                    b.Navigation("WorkerFramesOut");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminBill", b =>
                {
                    b.Navigation("AdminBillFrameTypes");
                });

            modelBuilder.Entity("FramesBlazor.Models.AdminFramesOut", b =>
                {
                    b.Navigation("AdminFramesOutNumbers");
                });

            modelBuilder.Entity("FramesBlazor.Models.Worker", b =>
                {
                    b.Navigation("WorkerBills");

                    b.Navigation("WorkerFramesIn");

                    b.Navigation("WorkerFramesOut");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerBill", b =>
                {
                    b.Navigation("WorkerBillFrameTypes");
                });

            modelBuilder.Entity("FramesBlazor.Models.WorkerFramesOut", b =>
                {
                    b.Navigation("WorkerFramesOutNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}