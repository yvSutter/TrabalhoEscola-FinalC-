﻿// <auto-generated />
using Ap.Controle.Web.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EscolaProway.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("EscolaProway.Models.Aluno", b =>
                {
                    b.Property<int>("IdAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeAluno")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeMateria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdAluno");

                    b.HasIndex("IdProfessor");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("EscolaProway.Models.Professor", b =>
                {
                    b.Property<int>("IdProfessor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeProfessor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdProfessor");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("EscolaProway.Models.Aluno", b =>
                {
                    b.HasOne("EscolaProway.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EscolaProway.Models.Professor", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
