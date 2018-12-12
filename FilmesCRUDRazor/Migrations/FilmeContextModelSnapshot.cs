﻿// <auto-generated />
using System;
using FilmesCRUDRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmesCRUDRazor.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("FilmesCRUDRazor.Models.Filme", b =>
                {
                    b.Property<int>("FilmeID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Genero");

                    b.Property<decimal>("Preco");

                    b.Property<string>("Titulo");

                    b.HasKey("FilmeID");

                    b.ToTable("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
