﻿// <auto-generated />
using FolhaPagamento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FolhaPagamento.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("FolhaPagamento.Models.Folha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Fgts")
                        .HasColumnType("REAL");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Inss")
                        .HasColumnType("REAL");

                    b.Property<double>("Ir")
                        .HasColumnType("REAL");

                    b.Property<int>("Mes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SalarioBruto")
                        .HasColumnType("REAL");

                    b.Property<double>("SalarioLiquido")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Folhas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 2023,
                            Fgts = 0.0,
                            FuncionarioId = 1,
                            Inss = 0.0,
                            Ir = 0.0,
                            Mes = 2,
                            Quantidade = 40,
                            SalarioBruto = 0.0,
                            SalarioLiquido = 0.0,
                            Valor = 30m
                        },
                        new
                        {
                            Id = 2,
                            Ano = 2023,
                            Fgts = 0.0,
                            FuncionarioId = 2,
                            Inss = 0.0,
                            Ir = 0.0,
                            Mes = 1,
                            Quantidade = 60,
                            SalarioBruto = 0.0,
                            SalarioLiquido = 0.0,
                            Valor = 40m
                        });
                });

            modelBuilder.Entity("FolhaPagamento.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            FuncionarioId = 1,
                            Nome = "Alisson",
                            cpf = "08803431926"
                        },
                        new
                        {
                            FuncionarioId = 2,
                            Nome = "Wendel",
                            cpf = "12285720971"
                        });
                });

            modelBuilder.Entity("FolhaPagamento.Models.Folha", b =>
                {
                    b.HasOne("FolhaPagamento.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
