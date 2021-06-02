﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601073829_AddMaxLengthRoomType")]
    partial class AddMaxLengthRoomType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeFirst.Models.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CodeFirst.Models.roomModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("roomType")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
