using Microsoft.EntityFrameworkCore;

namespace MoviesWebApp.Components.DataBase
{
    public class MoviesDB : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public MoviesDB(DbContextOptions<MoviesDB> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().HasKey(m => m.Id);
            modelBuilder.Entity<Movies>().Property(m => m.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Rating>().HasKey(r => r.Id);
            modelBuilder.Entity<Rating>().Property(r => r.Id).ValueGeneratedOnAdd();
        }
        private static string GetConnectionString()
        {
            // Retrieve the connection string from a configuration file or environment variable
            return "Server=(localdb)\\mssqllocaldb;Database=MoviesDB;Trusted_Connection=True;";
        }
    }
}
