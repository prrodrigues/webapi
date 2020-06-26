﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectShcool_Api.Data;

namespace ProjectShcool_Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200626030451_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ProjectShcool_Api.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("professorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("professorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            dataNasc = "01-02-2010",
                            nome = "Aluno Vinicius",
                            professorId = 2,
                            sobrenome = "de Moraes"
                        },
                        new
                        {
                            id = 2,
                            dataNasc = "01-01-2005",
                            nome = "Aluno Helena",
                            professorId = 3,
                            sobrenome = "Gonzales"
                        },
                        new
                        {
                            id = 3,
                            dataNasc = "01-01-2012",
                            nome = "Aluno Luna",
                            professorId = 1,
                            sobrenome = "de Lunares"
                        });
                });

            modelBuilder.Entity("ProjectShcool_Api.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            id = 1,
                            dataNasc = "01-02-2000",
                            nome = "Vinicius",
                            sobrenome = "de Moraes"
                        },
                        new
                        {
                            id = 2,
                            dataNasc = "01-01-1999",
                            nome = "Helena",
                            sobrenome = "Gonzales"
                        },
                        new
                        {
                            id = 3,
                            dataNasc = "01-01-1800",
                            nome = "Luna",
                            sobrenome = "de Lunares"
                        });
                });

            modelBuilder.Entity("ProjectShcool_Api.Models.Aluno", b =>
                {
                    b.HasOne("ProjectShcool_Api.Models.Professor", null)
                        .WithMany("alunos")
                        .HasForeignKey("professorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });


        }
    }
}
