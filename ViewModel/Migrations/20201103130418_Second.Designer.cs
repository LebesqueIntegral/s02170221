﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViewModel;

namespace ViewModel.Migrations
{
    [DbContext(typeof(PictureLibraryContext))]
    [Migration("20201103130418_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("ViewModel.PictureInfoDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PictureInfoDetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortFileName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PictureInfoDetailsId");

                    b.HasIndex("TypeId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("ViewModel.PictureInfoDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("BinaryFile")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("ViewModel.PictureTypeDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("ViewModel.PictureInfoDB", b =>
                {
                    b.HasOne("ViewModel.PictureInfoDetails", "PictureInfoDetails")
                        .WithMany()
                        .HasForeignKey("PictureInfoDetailsId");

                    b.HasOne("ViewModel.PictureTypeDB", "Type")
                        .WithMany("Pictures")
                        .HasForeignKey("TypeId");

                    b.Navigation("PictureInfoDetails");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("ViewModel.PictureTypeDB", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}