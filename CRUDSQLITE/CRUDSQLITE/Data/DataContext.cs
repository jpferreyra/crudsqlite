using CRUDSQLITE.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDSQLITE.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Data/db.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(a => a.Id);
        }
    }
}
