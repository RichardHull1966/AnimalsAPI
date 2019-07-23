using Microsoft.EntityFrameworkCore;
using AnimalsAPI.Domain.Models;

namespace AnimalsAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
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

            modelBuilder.Entity<Cat>().ToTable("Cats");
            modelBuilder.Entity<Cat>().HasKey(p => p.Id);
            modelBuilder.Entity<Cat>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Cat>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Cat>().Property(p => p.Type).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Cat>().Property(p => p.YearOfBirth).IsRequired();

            modelBuilder.Entity<Cat>().HasData
            (
                new Cat { Id = 1, Name = "Amber", Type = "Bengal", YearOfBirth = 2000 },
                new Cat { Id = 2, Name = "Tiddles", Type = "Tabby", YearOfBirth = 2010 },
                new Cat { Id = 3, Name = "Mr Mestopheles", Type = "Ginger tom", YearOfBirth = 2001 },
                new Cat { Id = 4, Name = "Spot", Type = "Old moggy", YearOfBirth = 2012 }
            );
        }
    }
}
