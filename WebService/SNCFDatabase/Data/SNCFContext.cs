using Microsoft.EntityFrameworkCore;
using SNCFDatabase.Models;

namespace SNCFDatabase.Data
{
    public class SNCFContext : DbContext 
    {
        public SNCFContext(DbContextOptions<SNCFContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Opinion> Opinions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("City").Property(t => t.ID).ValueGeneratedNever();
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Forum>().ToTable("Forum");
            modelBuilder.Entity<Mark>().ToTable("Mark");
            modelBuilder.Entity<Opinion>().ToTable("Opinion");
        }
    }
}
