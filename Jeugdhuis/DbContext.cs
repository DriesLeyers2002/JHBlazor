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

        var adminRole = new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" };
        var voorzitterRole = new IdentityRole { Id = "2", Name = "Voorzitter", NormalizedName = "VOORZITTER" };
        var drankmeesterRole = new IdentityRole { Id = "3", Name = "Drankmeester", NormalizedName = "DRANKMEESTER" };

        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(64);
            entity.Property(m => m.NormalizedName).HasMaxLength(256);
            entity.HasIndex(m => m.NormalizedName).IsUnique().HasDatabaseName("RoleNameIndex");
        });

        modelBuilder.Entity<Boardmember>().ToTable("AspNetUsers");

        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(64);
            entity.Property(m => m.RoleId).HasMaxLength(64);
            entity.HasKey(ur => new { ur.UserId, ur.RoleId });
        });

        modelBuilder.Entity<IdentityUser>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(128);
            entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
            entity.Property(m => m.NormalizedEmail).HasMaxLength(256);

            entity.HasIndex(m => m.NormalizedUserName).IsUnique().HasDatabaseName("UserNameIndex")
                  .HasFilter("[NormalizedUserName] IS NOT NULL");
        });

        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.Property(m => m.LoginProvider).HasMaxLength(100);
            entity.Property(m => m.ProviderKey).HasMaxLength(100);
            entity.Property(m => m.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(64);
            entity.Property(m => m.LoginProvider).HasMaxLength(64);
            entity.Property(m => m.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(m => m.UserId).HasMaxLength(128);
            entity.Property(m => m.RoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<Boardmember>(entity =>
        {
            entity.Property(m => m.Id).HasMaxLength(64);
            entity.Property(m => m.NormalizedUserName).HasMaxLength(256);
            entity.Property(m => m.NormalizedEmail).HasMaxLength(256);
            entity.HasIndex(m => m.NormalizedUserName).IsUnique().HasDatabaseName("UserNameIndex");
        });

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
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Address = "123 Main St", Years = new List<int> { 2023, 2024 } },
            new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Address = "456 Elm St", Years = new List<int> { 2024 } },
            new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alica.johnson@example.com", Address = "789 Maple St", Years = new List<int> { 2022 } }
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
