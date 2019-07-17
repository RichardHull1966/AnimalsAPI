using System;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Domain.Models;

namespace MoviesAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Movie>().HasKey(p => p.Id);
            modelBuilder.Entity<Movie>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.Year).IsRequired();

            modelBuilder.Entity<Movie>().HasData
            (
                new Movie { Id = 10, Name = "Alien", Year = 2000 },
                new Movie { Id = 20, Name = "Terminator", Year = 2001 },
                new Movie { Id = 30, Name = "Terminator 2", Year = 2002 }
            );
        }
    }
}
