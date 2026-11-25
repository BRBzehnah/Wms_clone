using Microsoft.EntityFrameworkCore;
using Wms_clone.Data.Models;

namespace Wms_clone.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<OrderTask> Tasks { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<StockItem> StockItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Если вы подключаете БД без DI (например, в WPF), раскомментируйте этот метод:
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=wms_db;Username=postgres;Password=your_password");
            }
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Явная настройка двойной связи StockMovement -> Cell (FromCell и ToCell)
            modelBuilder.Entity<StockMovement>(entity =>
            {
                entity.HasOne(m => m.FromCell)
                      .WithMany() // У Cell нет отдельного списка исходящих перемещений
                      .OnDelete(DeleteBehavior.Restrict); // Запрещаем каскадное удаление истории при удалении ячейки

                entity.HasOne(m => m.ToCell)
                      .WithMany() // У Cell нет отдельного списка входящих перемещений
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // 2. Уникальные индексы для защиты целостности данных в PostgreSQL
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();

            modelBuilder.Entity<Cell>()
                .HasIndex(c => c.Barcode)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Barcode)
                .IsUnique();
        }
    }
}
