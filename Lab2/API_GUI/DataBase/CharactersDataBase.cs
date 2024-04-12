using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_GUI.DataBase
{
    internal class CharactersDataBase : DbContext
    {
        // DbContextOptionsBuilder.EnableSensitiveDataLogging 
        public DbSet<Characters_DB.Result_DB> Character { get; set; }
        public CharactersDataBase()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Debug
            string binPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = Path.Combine(binPath, "characters.db");
            options.UseSqlite($"Data Source={databasePath}");
            // Release
            //options.UseSqlite(@"Data Source=characters.db");
            options.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters_DB.Result_DB>().HasKey(c => c.Key);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.id).IsRequired();
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.name).HasMaxLength(50);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.status).HasMaxLength(15);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.species).HasMaxLength(50);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.type).HasMaxLength(50);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.gender).HasMaxLength(15);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.origin).HasMaxLength(255);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.location).HasMaxLength(255);
            modelBuilder.Entity<Characters_DB.Result_DB>().Property(c => c.url).HasMaxLength(255);
        }
    }
}
