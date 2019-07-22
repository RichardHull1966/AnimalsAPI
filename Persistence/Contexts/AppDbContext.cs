using System;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Domain.Models;

namespace MoviesAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Hamster> Hamsters { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hamster>().ToTable("Hamsters");
            modelBuilder.Entity<Hamster>().HasKey(p => p.Id);
            modelBuilder.Entity<Hamster>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Hamster>().Property(p => p.Name).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<Hamster>().Property(p => p.Year).IsRequired();

            modelBuilder.Entity<Hamster>().HasData
            (
                new Hamster { Id = 1, Name = "Alien", Year = 2000 },
                new Hamster { Id = 2, Name = "Terminator", Year = 2001 },
                new Hamster { Id = 3, Name = "Terminator 2", Year = 2002 }
            );

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Movie>().Property(p => p.Id).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Movie>().Property(p => p.Year).IsRequired();
        }
    }
}
