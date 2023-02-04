using Microsoft.EntityFrameworkCore;
using DatabaseCatalog.Models;

namespace DatabaseCatalog
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Material> Materials { get; set; } = null!;

        public DbSet<Manager> Managers { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=printApp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Volume).IsRequired();

                entity.Property(e => e.Date).IsRequired();
            });

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Manager)
                .WithMany(e => e.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Material)
                .WithMany(e => e.Orders);

            modelBuilder.Entity<Order>()
                .HasAlternateKey(e => new { e.ManagerId, e.MaterialId });


            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Surname).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Patronymic).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Appointment).IsRequired().HasMaxLength(255);
            });


            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.Id);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Type).IsRequired().HasMaxLength(255);

                entity.Property(e => e.PaperSettings).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Date).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
