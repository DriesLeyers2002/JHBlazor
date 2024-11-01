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

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var hasher = new PasswordHasher<Boardmember>();

        // Configuring IdentityRole to reduce Id length for MySQL compatibility
        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(64); // Verander naar 64
            entity.Property(m => m.NormalizedName).HasMaxLength(256);
            entity.HasIndex(m => m.NormalizedName).IsUnique().HasDatabaseName("RoleNameIndex");
        });

        modelBuilder.Entity<Boardmember>().ToTable("AspNetUsers");

        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(64);  // Verander naar 64
            entity.Property(m => m.RoleId).HasMaxLength(64);  // Verander naar 64
            entity.HasKey(ur => new { ur.UserId, ur.RoleId });
        });

        modelBuilder.Entity<IdentityUser>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(128);
            entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
            entity.Property(m => m.NormalizedEmail).HasMaxLength(256);

            entity.HasIndex(m => m.NormalizedUserName).IsUnique().HasDatabaseName("UserNameIndex")
                  .HasFilter("[NormalizedUserName] IS NOT NULL"); // Avoid index issues with NULLs
        });

        // Configuring IdentityUserLogin to reduce key lengths
        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.Property(m => m.LoginProvider).HasMaxLength(100);
            entity.Property(m => m.ProviderKey).HasMaxLength(100);
            entity.Property(m => m.UserId).HasMaxLength(100);
        });

        // Configuring IdentityUserToken to reduce key lengths
        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(64);  // Reduce UserId length
            entity.Property(m => m.LoginProvider).HasMaxLength(64);
            entity.Property(m => m.Name).HasMaxLength(64);
        });

        // Configuring IdentityUserRole to reduce key lengths and setting composite primary key
        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(128);
            entity.Property(m => m.RoleId).HasMaxLength(128);
        });

        // Configuring Boardmember entity (inheriting from IdentityUser)
        modelBuilder.Entity<Boardmember>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(64); // Verander naar 64
            entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
            entity.Property(m => m.NormalizedEmail).HasMaxLength(256);
            entity.HasIndex(m => m.NormalizedUserName).IsUnique().HasDatabaseName("UserNameIndex");
        });

        // Drink Entity Configuration
        modelBuilder.Entity<Drink>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        // User Entity Configuration
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        // StockItem Entity Configuration
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
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Address = "123 Main St", Years = new List<int> { 2023, 2024 } },
            new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Address = "456 Elm St", Years = new List<int> { 2024 } },
            new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.There is no entity type mapped to the table 'Boardmembers' which is used in a data operation. Either add the corresponding entity type to the model, or specify the column types in the data operation.ohnson@example.com", Address = "789 Maple St", Years = new List<int> { 2022 } }
        );

        modelBuilder.Entity<Boardmember>().HasData(
        new Boardmember
        {
            Id = "1", // IdentityUser requires a string Id
            UserName = "Dries",
            Name = "Dries",
            NormalizedUserName = "DRIES",
            Email = "dries@example.com",
            NormalizedEmail = "DRIES@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"), // Or use a specific password
            Role = "Admin"
        },
        new Boardmember
        {
            Id = "2",
            Name = "Vincent",
            UserName = "Vincent",
            NormalizedUserName = "VINCENT",
            Email = "vincent@example.com",
            NormalizedEmail = "VINCENT@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"),
            Role = "Voorzitter"
        },
        new Boardmember
        {

            Id = "3",
            UserName = "Simon",
            Name = "Simon",
            NormalizedUserName = "SIMON",
            Email = "simon@example.com",
            NormalizedEmail = "SIMON@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "1234"),
            Role = "Drankmeester"
        }
    );
    }
}
