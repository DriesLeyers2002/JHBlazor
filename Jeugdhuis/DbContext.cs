using Jeugdhuis.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Drink> Drinks { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<StockItem> StockItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Drink>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.HasMany(s => s.DrinkStock)
                  .WithOne(si => si.Stock)
                  .HasForeignKey(si => si.StockId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.HasKey(si => si.Id);
            entity.HasOne(si => si.Drink)
                  .WithMany()
                  .HasForeignKey(si => si.DrinkId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Drink>().HasData(
           new Drink { Id = 1, Name = "AirFryer snacks", Price = 3.00, Category = "snacks" },
           new Drink { Id = 2, Name = "Bier van de maand", Price = 3.00, Category = "bier" },
           new Drink { Id = 3, Name = "Bruiswater", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 4, Name = "Buta ranzige Biru", Price = 2.50, Category = "bier" },
           new Drink { Id = 5, Name = "Chouffe", Price = 3.00, Category = "bier" },
           new Drink { Id = 6, Name = "Cherry Chouffe", Price = 3.00, Category = "bier" },
           new Drink { Id = 7, Name = "Cola", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 8, Name = "Cola zero", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 9, Name = "Cornet", Price = 3.00, Category = "bier" },
           new Drink { Id = 10, Name = "Duvel", Price = 3.00, Category = "bier" },
           new Drink { Id = 11, Name = "Fanta", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 12, Name = "Fles Cava", Price = 15.00, Category = "wijn" },
           new Drink { Id = 13, Name = "Glas Cava", Price = 3.00, Category = "wijn" },
           new Drink { Id = 14, Name = "Glas Rosé", Price = 3.00, Category = "wijn" },
           new Drink { Id = 15, Name = "Glas witte wijn", Price = 3.00, Category = "wijn" },
           new Drink { Id = 16, Name = "Gouden Carolus Classic", Price = 3.00, Category = "bier" },
           new Drink { Id = 17, Name = "Gouden Carolus tripel", Price = 3.00, Category = "bier" },
           new Drink { Id = 18, Name = "Groene", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 19, Name = "Ice Tea", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 20, Name = "Jupiler 0.0", Price = 1.50, Category = "Mietenbier" },
           new Drink { Id = 21, Name = "Kriek", Price = 2.00, Category = "bier" },
           new Drink { Id = 22, Name = "Maes fles", Price = 1.50, Category = "bier" },
           new Drink { Id = 23, Name = "Maes tap", Price = 1.50, Category = "bier" },
           new Drink { Id = 24, Name = "Pizna baguette", Price = 2.00, Category = "snacks" },
           new Drink { Id = 25, Name = "Plat water", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 26, Name = "Sprite", Price = 1.50, Category = "frisdrank" },
           new Drink { Id = 27, Name = "Stella fles", Price = 1.50, Category = "bier" },
           new Drink { Id = 28, Name = "Stella tap", Price = 1.50, Category = "bier" },
           new Drink { Id = 29, Name = "Toogkletser", Price = 5.00, Category = "snacks" },
           new Drink { Id = 30, Name = "Zakje chips ouleh", Price = 1.50, Category = "snacks" }
       );

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Address = "123 Main St", Year = 2022 },
            new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Address = "456 Elm St", Year = 2023 },
            new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Address = "789 Maple St", Year = 2024 }
        );
    }
}
