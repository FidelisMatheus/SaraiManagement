﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaraiManagement.Models;

namespace SaraiManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210514173512_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaraiManagement.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Admissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonatarioID")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NomeResponsavel")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Período")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoID");

                    b.HasIndex("DonatarioID")
                        .IsUnique();

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("SaraiManagement.Models.Caixa", b =>
                {
                    b.Property<int>("CaixaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("CaixaID");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("SaraiManagement.Models.Doacao", b =>
                {
                    b.Property<int>("DoacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonatarioID")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataDoacao")
                        .HasColumnType("datetime2");

                    b.Property<double>("valorDoacao")
                        .HasColumnType("float");

                    b.HasKey("DoacaoID");

                    b.HasIndex("DonatarioID");

                    b.ToTable("Doacaos");
                });

            modelBuilder.Entity("SaraiManagement.Models.Doador", b =>
                {
                    b.Property<int>("DoadorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("inicioDaDoacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("regularidadeDoador")
                        .HasColumnType("int");

                    b.HasKey("DoadorID");

                    b.ToTable("Doadors");
                });

            modelBuilder.Entity("SaraiManagement.Models.Donatario", b =>
                {
                    b.Property<int>("DonatarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonatarioID");

                    b.ToTable("Donatarios");
                });

            modelBuilder.Entity("SaraiManagement.Models.Estoque", b =>
                {
                    b.Property<int>("EstoqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.HasKey("EstoqueID");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("SaraiManagement.Models.ItemDoado", b =>
                {
                    b.Property<int>("ItemDoadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoacaoID")
                        .HasColumnType("int");

                    b.Property<int>("EstoqueID")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ItemDoadoID");

                    b.HasIndex("DoacaoID");

                    b.HasIndex("EstoqueID")
                        .IsUnique();

                    b.ToTable("ItemDoados");
                });

            modelBuilder.Entity("SaraiManagement.Models.Movimentacao", b =>
                {
                    b.Property<int>("MovimentacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaixaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiaMovimentacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoMovimentacao")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("MovimentacaoID");

                    b.HasIndex("CaixaID");

                    b.ToTable("Movimentacaos");
                });

            modelBuilder.Entity("SaraiManagement.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SaraiManagement.Models.Aluno", b =>
                {
                    b.HasOne("SaraiManagement.Models.Donatario", "Donatario")
                        .WithOne("Aluno")
                        .HasForeignKey("SaraiManagement.Models.Aluno", "DonatarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donatario");
                });

            modelBuilder.Entity("SaraiManagement.Models.Doacao", b =>
                {
                    b.HasOne("SaraiManagement.Models.Donatario", "Donatario")
                        .WithMany("Doacao")
                        .HasForeignKey("DonatarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donatario");
                });

            modelBuilder.Entity("SaraiManagement.Models.ItemDoado", b =>
                {
                    b.HasOne("SaraiManagement.Models.Doacao", "Doacao")
                        .WithMany()
                        .HasForeignKey("DoacaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaraiManagement.Models.Estoque", "Estoque")
                        .WithOne("ItemDoado")
                        .HasForeignKey("SaraiManagement.Models.ItemDoado", "EstoqueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doacao");

                    b.Navigation("Estoque");
                });

            modelBuilder.Entity("SaraiManagement.Models.Movimentacao", b =>
                {
                    b.HasOne("SaraiManagement.Models.Caixa", "Caixa")
                        .WithMany()
                        .HasForeignKey("CaixaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caixa");
                });

            modelBuilder.Entity("SaraiManagement.Models.Donatario", b =>
                {
                    b.Navigation("Aluno");

                    b.Navigation("Doacao");
                });

            modelBuilder.Entity("SaraiManagement.Models.Estoque", b =>
                {
                    b.Navigation("ItemDoado");
                });
#pragma warning restore 612, 618
        }
    }
}
