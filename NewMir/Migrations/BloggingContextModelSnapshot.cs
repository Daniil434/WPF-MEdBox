﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewMir;

namespace NewMir.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("NewMir.Good_Talon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("fio")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("name_hospital")
                        .HasColumnType("TEXT");

                    b.Property<string>("number_kabinet")
                        .HasColumnType("TEXT");

                    b.Property<string>("otchestvo")
                        .HasColumnType("TEXT");

                    b.Property<int>("stoimost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("vrach")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Good_Talons");
                });

            modelBuilder.Entity("NewMir.Hospital", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("adres")
                        .HasColumnType("TEXT");

                    b.Property<string>("all_vrach")
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("NewMir.Kabinet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("number_kabinet")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Kabinets");
                });

            modelBuilder.Entity("NewMir.Story", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("fio")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("name_hospital")
                        .HasColumnType("TEXT");

                    b.Property<int>("number_kabinet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("otchestvo")
                        .HasColumnType("TEXT");

                    b.Property<int>("stoimost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("vrach")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("NewMir.Talon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("fio")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("otchestvo")
                        .HasColumnType("TEXT");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("vrach")
                        .HasColumnType("TEXT");

                    b.Property<int>("yslyga")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Talons");
                });

            modelBuilder.Entity("NewMir.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("fio")
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .HasColumnType("TEXT");

                    b.Property<string>("login")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("otchestvo")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<bool>("prava_dostypa")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NewMir.Vrach", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grahic_vrach")
                        .HasColumnType("TEXT");

                    b.Property<string>("fio")
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("name_hospital")
                        .HasColumnType("TEXT");

                    b.Property<int>("number_kabinet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("otchestvo")
                        .HasColumnType("TEXT");

                    b.Property<string>("spechialnost")
                        .HasColumnType("TEXT");

                    b.Property<string>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Vrachs");
                });

            modelBuilder.Entity("NewMir.Yslyga", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("stoimost")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Yslygs");
                });
#pragma warning restore 612, 618
        }
    }
}
