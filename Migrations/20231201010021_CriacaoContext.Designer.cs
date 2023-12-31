﻿// <auto-generated />
using System;
using ASP_NET_MVC.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_NET_MVC.Migrations
{
    [DbContext(typeof(ASP_NET_MVC.Context.Context))]
    [Migration("20231201010021_CriacaoContext")]
    partial class CriacaoContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_NET_MVC.Models.Cargos", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cargo_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoId"));

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int")
                        .HasColumnName("departamento_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<int>("Salario")
                        .HasColumnType("int")
                        .HasColumnName("salario");

                    b.HasKey("CargoId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("ASP_NET_MVC.Models.Departamentos", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("departamento_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("ASP_NET_MVC.Models.Funcionarios", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("funcionario_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionarioId"));

                    b.Property<int>("CargoId")
                        .HasColumnType("int")
                        .HasColumnName("cargo_id");

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_contratacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ASP_NET_MVC.Models.Cargos", b =>
                {
                    b.HasOne("ASP_NET_MVC.Models.Departamentos", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("ASP_NET_MVC.Models.Funcionarios", b =>
                {
                    b.HasOne("ASP_NET_MVC.Models.Cargos", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });
#pragma warning restore 612, 618
        }
    }
}
