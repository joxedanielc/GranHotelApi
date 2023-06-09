﻿// <auto-generated />
using System;
using GranHotelApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GranHotelApi.Migrations
{
    [DbContext(typeof(GranHotelContext))]
    [Migration("20230401195521_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GranHotelApi.Models.Habitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ocupada")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("GranHotelApi.Models.Huesped", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Ingreso")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Salida")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("HabitacionId");

                    b.ToTable("Huespedes");
                });

            modelBuilder.Entity("GranHotelApi.Models.Huesped", b =>
                {
                    b.HasOne("GranHotelApi.Models.Habitacion", "Habitacion")
                        .WithMany("Huespedes")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");
                });

            modelBuilder.Entity("GranHotelApi.Models.Habitacion", b =>
                {
                    b.Navigation("Huespedes");
                });
#pragma warning restore 612, 618
        }
    }
}
