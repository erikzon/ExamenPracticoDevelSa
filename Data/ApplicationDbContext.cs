﻿using Microsoft.EntityFrameworkCore;
using ExamenPractico.Models;

namespace ExamenPractico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }
        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<Campo> Campos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Name=ConnectionStrings:FormsDB");
    }
}
