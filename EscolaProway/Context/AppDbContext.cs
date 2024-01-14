using EscolaProway.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace Ap.Controle.Web.Context;


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
    }
