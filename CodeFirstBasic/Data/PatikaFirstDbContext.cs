using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb1");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Movie>()
                .HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Action", ReleaseYear = 2010 },
                new Movie { Id = 2, Title = "The Matrix", Genre = "Action", ReleaseYear = 1999 },
                new Movie { Id = 3, Title = "The Pursuit of Happyness", Genre = "Drama", ReleaseYear = 2006 }
                );

            modelBuilder
                .Entity<Game>()
                .HasData(
                new Game { Id = 1, Name = "The Witcher 3", Platform = "PC", Rating = 9.5m },
                new Game { Id = 2, Name = "God of War", Platform = "PlayStation", Rating = 9.7m },
                new Game { Id = 3, Name = "Minecraft", Platform = "Xbox", Rating = 8.9m }
                );
        }
    }
}
