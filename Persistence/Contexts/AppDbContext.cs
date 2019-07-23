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
            modelBuilder.Entity<Hamster>().Property(p => p.Age).IsRequired();

            modelBuilder.Entity<Hamster>().HasData
            (
                new Hamster { Id = 1, Name = "Squealer", Age = 2 },
                new Hamster { Id = 2, Name = "Squidgy", Age = 1 },
                new Hamster { Id = 3, Name = "Fluff Bag", Age = 3 }
            );

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Movie>().Property(p => p.Id).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Movie>().Property(p => p.Year).IsRequired();

            modelBuilder.Entity<Movie>().HasData
            (
                new Movie { Id = 1, Name = "It's a wonderful life", Year = 2000 },
                new Movie { Id = 2, Name = "A Star is Born", Year = 2001 },
                new Movie { Id = 3, Name = "Amelie", Year = 2002 }
            );
        }
    }
}
