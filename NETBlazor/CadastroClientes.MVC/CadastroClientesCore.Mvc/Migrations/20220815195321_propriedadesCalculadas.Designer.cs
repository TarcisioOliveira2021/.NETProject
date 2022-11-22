﻿// <auto-generated />
using System;
using CadastroClientesCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroClientes.MVC.Migrations
{
    [DbContext(typeof(CadastroClientesContext))]
    [Migration("20220815195321_propriedadesCalculadas")]
    partial class propriedadesCalculadas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("CadastroClientes.MVC.Models.ModeloCliente", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CPF");

                    b.ToTable("clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
