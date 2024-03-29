﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nutricion.API.Data;

#nullable disable

namespace Nutricion.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231004225845_IMC")]
    partial class IMC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nutricion.API.Models.IMC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Altura")
                        .HasColumnType("real");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<float>("Resultado")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("RegistrosIMC");
                });
#pragma warning restore 612, 618
        }
    }
}
