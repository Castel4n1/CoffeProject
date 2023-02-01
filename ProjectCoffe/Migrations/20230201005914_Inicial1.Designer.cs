﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectCoffe.Data;

#nullable disable

namespace ProjectCoffe.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230201005914_Inicial1")]
    partial class Inicial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectCoffe.Models.Compromisso", b =>
                {
                    b.Property<int>("OrganizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("OrganizacaoId", "PessoaId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Compromissos");
                });

            modelBuilder.Entity("ProjectCoffe.Models.Organizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Semana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizacaos");
                });

            modelBuilder.Entity("ProjectCoffe.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ProjectCoffe.Models.Compromisso", b =>
                {
                    b.HasOne("ProjectCoffe.Models.Organizacao", "Organizacao")
                        .WithMany()
                        .HasForeignKey("OrganizacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectCoffe.Models.Pessoa", "Pessoa")
                        .WithMany("Compromissos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organizacao");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjectCoffe.Models.Pessoa", b =>
                {
                    b.Navigation("Compromissos");
                });
#pragma warning restore 612, 618
        }
    }
}
