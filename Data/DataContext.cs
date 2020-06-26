using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectShcool_Api.Models;

namespace ProjectShcool_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Professor>()
            .HasData(
                new List<Professor>(){
                    new Professor() {
                    id = 1,
                    nome = "Vinicius",
                    sobrenome = "de Moraes",
                    dataNasc = "01-02-2000"
                    },
                    new Professor() {
                    id = 2,
                    nome = "Helena",
                    sobrenome = "Gonzales",
                    dataNasc = "01-01-1999"
                    },
                    new Professor() {
                    id = 3,
                    nome = "Luna",
                    sobrenome = "de Lunares",
                    dataNasc = "01-01-1800"
                    },
                }
            );

            builder.Entity<Aluno>()
            .HasData(
                new List<Aluno>(){
                    new Aluno() {
                    id = 1,
                    nome = "Aluno Vinicius",
                    sobrenome = "de Moraes",
                    dataNasc = "01-02-2010",
                    professorId = 2
                    },
                    new Aluno() {
                    id = 2,
                    nome = "Aluno Helena",
                    sobrenome = "Gonzales",
                    dataNasc = "01-01-2005",
                    professorId = 3
                    },
                    new Aluno() {
                    id = 3,
                    nome = "Aluno Luna",
                    sobrenome = "de Lunares",
                    dataNasc = "01-01-2012",
                    professorId = 1
                    },
                }
            );


        }
    }
}