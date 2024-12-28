using Jeugdhuis.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class AppDbContext : IdentityDbContext<Boardmember>
{
    public DbSet<Drink> Drinks { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<StockItem> StockItems { get; set; }
    public DbSet<Boardmember> Boardmembers { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<NfcCard> NfcCards { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var hasher = new PasswordHasher<Boardmember>();

        var adminRole = new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" };
        var voorzitterRole = new IdentityRole { Id = "2", Name = "Voorzitter", NormalizedName = "VOORZITTER" };
        var drankmeesterRole = new IdentityRole { Id = "3", Name = "Drankmeester", NormalizedName = "DRANKMEESTER" };

        modelBuilder.Entity<Drink>(entity =>
        {
            entity.HasKey(d => d.Id);
            entity.Property(d => d.Id).ValueGeneratedOnAdd();
            entity.HasOne(d => d.Category)
                  .WithMany()
                  .HasForeignKey(d => d.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<NfcCard>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(c => c.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.HasKey(si => si.Id);
            entity.HasOne(si => si.Drink)
                  .WithMany()
                  .HasForeignKey(si => si.DrinkId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).ValueGeneratedOnAdd();
            entity.Property(c => c.Name).IsRequired();
            entity.Property(c => c.Color).IsRequired();
        });

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "snacks", Color = "#FFA500" },
            new Category { Id = 2, Name = "bier", Color = "#FFD700" },
            new Category { Id = 3, Name = "frisdrank", Color = "#00BFFF" },
            new Category { Id = 4, Name = "wijn", Color = "#8B0000" },
            new Category { Id = 5, Name = "cocktails", Color = "#D85E5E" },
            new Category { Id = 6, Name = "andere", Color = "#3285a8" }
        );

        modelBuilder.Entity<Drink>().HasData(
            new Drink { Id = 1, Name = "AirFryer snacks", Price = 3.00, CategoryId = 1 },
            new Drink { Id = 2, Name = "Bier van de maand", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 3, Name = "Bruiswater", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 4, Name = "Buta ranzige Biru", Price = 2.50, CategoryId = 2 },
            new Drink { Id = 5, Name = "Chouffe", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 6, Name = "Cherry Chouffe", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 7, Name = "Cola", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 8, Name = "Cola zero", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 9, Name = "Cornet", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 10, Name = "Duvel", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 11, Name = "Fanta", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 12, Name = "Fles Cava", Price = 15.00, CategoryId = 4 },
            new Drink { Id = 13, Name = "Glas Cava", Price = 3.00, CategoryId = 4 },
            new Drink { Id = 14, Name = "Glas Rosé", Price = 3.00, CategoryId = 4 },
            new Drink { Id = 15, Name = "Glas witte wijn", Price = 3.00, CategoryId = 4 },
            new Drink { Id = 16, Name = "Gouden Carolus Classic", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 17, Name = "Gouden Carolus tripel", Price = 3.00, CategoryId = 2 },
            new Drink { Id = 18, Name = "Groene", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 19, Name = "Ice Tea", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 20, Name = "Jupiler 0.0", Price = 1.50, CategoryId = 2 },
            new Drink { Id = 21, Name = "Kriek", Price = 2.00, CategoryId = 2 },
            new Drink { Id = 22, Name = "Maes fles", Price = 1.50, CategoryId = 2 },
            new Drink { Id = 23, Name = "Maes tap", Price = 1.50, CategoryId = 2 },
            new Drink { Id = 24, Name = "Pizna baguette", Price = 2.00, CategoryId = 1 },
            new Drink { Id = 25, Name = "Plat water", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 26, Name = "Sprite", Price = 1.50, CategoryId = 3 },
            new Drink { Id = 27, Name = "Stella fles", Price = 1.50, CategoryId = 2 },
            new Drink { Id = 28, Name = "Stella tap", Price = 1.50, CategoryId = 2 },
            new Drink { Id = 29, Name = "Toogkletser", Price = 5.00, CategoryId = 1 },
            new Drink { Id = 30, Name = "Zakje chips ouleh", Price = 1.50, CategoryId = 1 }
        );


        modelBuilder.Entity<StockItem>().HasData(
            new StockItem { Id = 1, DrinkId = 1, Quantity = 20 },
            new StockItem { Id = 2, DrinkId = 2, Quantity = 15 },
            new StockItem { Id = 3, DrinkId = 3, Quantity = 25 },
            new StockItem { Id = 4, DrinkId = 4, Quantity = 10 },
            new StockItem { Id = 5, DrinkId = 5, Quantity = 12 },
            new StockItem { Id = 6, DrinkId = 6, Quantity = 18 },
            new StockItem { Id = 7, DrinkId = 7, Quantity = 30 },
            new StockItem { Id = 8, DrinkId = 8, Quantity = 28 },
            new StockItem { Id = 9, DrinkId = 9, Quantity = 14 },
            new StockItem { Id = 10, DrinkId = 10, Quantity = 16 },
            new StockItem { Id = 11, DrinkId = 11, Quantity = 22 },
            new StockItem { Id = 12, DrinkId = 12, Quantity = 5 },
            new StockItem { Id = 13, DrinkId = 13, Quantity = 8 },
            new StockItem { Id = 14, DrinkId = 14, Quantity = 10 },
            new StockItem { Id = 15, DrinkId = 15, Quantity = 12 },
            new StockItem { Id = 16, DrinkId = 16, Quantity = 7 },
            new StockItem { Id = 17, DrinkId = 17, Quantity = 7 },
            new StockItem { Id = 18, DrinkId = 18, Quantity = 26 },
            new StockItem { Id = 19, DrinkId = 19, Quantity = 20 },
            new StockItem { Id = 20, DrinkId = 20, Quantity = 18 },
            new StockItem { Id = 21, DrinkId = 21, Quantity = 9 },
            new StockItem { Id = 22, DrinkId = 22, Quantity = 14 },
            new StockItem { Id = 23, DrinkId = 23, Quantity = 13 },
            new StockItem { Id = 24, DrinkId = 24, Quantity = 6 },
            new StockItem { Id = 25, DrinkId = 25, Quantity = 25 },
            new StockItem { Id = 26, DrinkId = 26, Quantity = 27 },
            new StockItem { Id = 27, DrinkId = 27, Quantity = 11 },
            new StockItem { Id = 28, DrinkId = 28, Quantity = 11 },
            new StockItem { Id = 29, DrinkId = 29, Quantity = 8 },
            new StockItem { Id = 30, DrinkId = 30, Quantity = 21 }
        );


        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Address = "123 Main St", Years = new List<int> { 2023, 2024 }, PhoneNumber = "123456789" },
            new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Address = "456 Elm St", Years = new List<int> { 2024 }, PhoneNumber = "123456789" },
            new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alica.johnson@example.com", Address = "789 Maple St", Years = new List<int> { 2022 }, PhoneNumber = "123456789" }
        );

        modelBuilder.Entity<IdentityRole>().HasData(adminRole, voorzitterRole, drankmeesterRole);

        var dries = new Boardmember
        {
            Id = "1",
            UserName = "Dries",
            NormalizedUserName = "DRIES",
            Email = "dries@example.com",
            NormalizedEmail = "DRIES@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"),
            IsActive = true
        };

        var vincent = new Boardmember
        {
            Id = "2",
            UserName = "Vincent",
            NormalizedUserName = "VINCENT",
            Email = "vincent@example.com",
            NormalizedEmail = "VINCENT@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"),
            IsActive = true
        };

        var simon = new Boardmember
        {
            Id = "3",
            UserName = "Simon",
            NormalizedUserName = "SIMON",
            Email = "simon@example.com",
            NormalizedEmail = "SIMON@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"),
            IsActive = true
        };

        modelBuilder.Entity<Boardmember>().HasData(dries, vincent, simon);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
           new IdentityUserRole<string> { UserId = dries.Id, RoleId = adminRole.Id },
           new IdentityUserRole<string> { UserId = vincent.Id, RoleId = voorzitterRole.Id },
           new IdentityUserRole<string> { UserId = vincent.Id, RoleId = adminRole.Id },
           new IdentityUserRole<string> { UserId = simon.Id, RoleId = drankmeesterRole.Id },
           new IdentityUserRole<string> { UserId = simon.Id, RoleId = adminRole.Id }
   );
    }
}
