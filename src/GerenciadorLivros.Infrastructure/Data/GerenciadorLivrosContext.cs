﻿using GerenciadorLivros.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GerenciadorLivros.Infrastructure.Data
{
    public class GerenciadorLivrosContext : DbContext
    {
        public GerenciadorLivrosContext(DbContextOptions<GerenciadorLivrosContext> options) 
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
