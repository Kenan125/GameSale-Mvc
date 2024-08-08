using GameSale_DataAccess.Identity;
using GameSale_Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_DataAccess.Contexts
{
    public class GameSaleDb : IdentityDbContext<AppUser,AppRole,int>
    {

        public GameSaleDb(DbContextOptions<GameSaleDb> options) : base(options)
        { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Game> GameSales { get; set; }
        public DbSet<GameSaleDetail> GameSaleDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SystemRequirement> SystemRequirements { get; set; }
        public DbSet<Publisher> Publishers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().
                Property(g => g.GameName).HasMaxLength(100);
            modelBuilder.Entity<Category>().
                Property(g => g.Name).HasMaxLength(100);
            modelBuilder.Entity<Game>().
                Property(m => m.ImgUrl).HasDefaultValue("/images/gamename.jpg");
            modelBuilder.Entity<Customer>().
                Property(m => m.ProfilePicture).HasDefaultValue("/images/customerpic.jpg");
            modelBuilder.Entity<Game>().
                HasOne(g=>g.Publisher).
                WithMany(p=> p.Games).
                HasForeignKey(g=>g.PublisherId);
            modelBuilder.Entity<Game>()
            .HasOne(g => g.Category) // Each game has one category
            .WithMany(c => c.Games)  // Each category can have many games
            .HasForeignKey(g => g.CategoryId);

            // Configuring the GameSale entity
            modelBuilder.Entity<GameSale>()
                .HasOne(gs => gs.Customer) // Each GameSale has one Customer
                .WithMany(c => c.GameSales) // Each Customer can have many GameSales
                .HasForeignKey(gs => gs.CustomerId); // Foreign key property

            // Configuring the GameSaleDetail entity
            modelBuilder.Entity<GameSaleDetail>()
                .HasOne(gsd => gsd.GameSale) // Each GameSaleDetail has one GameSale
                .WithMany(gs => gs.GameSaleDetails) // Each GameSale can have many GameSaleDetails
                .HasForeignKey(gsd => gsd.GameSaleId);

            modelBuilder.Entity<GameSaleDetail>()
           .HasOne(gsd => gsd.Game) // Each GameSaleDetail has one Game
           .WithMany() // Assuming a Game can have many GameSaleDetails
           .HasForeignKey(gsd => gsd.GameId); // Foreign key property


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Description = "Action games" },
                new Category { Id = 2, Name = "Adventure", Description = "Adventure games" },
                new Category { Id = 3, Name = "RPG", Description = "Role-playing games" },
                new Category { Id = 4, Name = "Strategy", Description = "Strategy games" },
                new Category { Id = 5, Name = "Simulation", Description = "Simulation games" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "123", UserName = "johndoe", Address = "123 Main St", PhoneNumber = "555-1234" },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Password = "123", UserName = "janesmith", Address = "456 Elm St", PhoneNumber = "555-5678" },
                new Customer { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Password = "123", UserName = "alicejohnson", Address = "789 Maple St", PhoneNumber = "555-7890" },
                new Customer { Id = 4, FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com", Password = "123", UserName = "bobbrown", Address = "321 Oak St", PhoneNumber = "555-6543" }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, GameName = "The Witcher 3: Wild Hunt", CategoryId = 3, Description = "An open-world RPG game", Price = 39.99M, Discount = 0, ImgUrl = "witcher3.jpg", Developer = "CD Projekt Red", PublisherId = 1, ReleaseDate = new DateTime(2015, 5, 19), Platform = "PC" },
                new Game { Id = 2, GameName = "Grand Theft Auto V", CategoryId = 1, Description = "An action-adventure game", Price = 29.99M, Discount = 20, ImgUrl = "gtav.jpg", Developer = "Rockstar North", PublisherId = 2, ReleaseDate = new DateTime(2013, 9, 17), Platform = "PC" },
                new Game { Id = 3, GameName = "Cyberpunk 2077", CategoryId = 3, Description = "A futuristic RPG game", Price = 59.99M, Discount = 10, ImgUrl = "cyberpunk2077.jpg", Developer = "CD Projekt Red", PublisherId = 1, ReleaseDate = new DateTime(2020, 12, 10), Platform = "PC" },
                new Game { Id = 4, GameName = "Red Dead Redemption 2", CategoryId = 2, Description = "An open-world adventure game", Price = 49.99M, Discount = 0, ImgUrl = "rdr2.jpg", Developer = "Rockstar Studios", PublisherId = 2, ReleaseDate = new DateTime(2018, 10, 26), Platform = "PC" },
                new Game { Id = 5, GameName = "Civilization VI", CategoryId = 4, Description = "A strategy game", Price = 39.99M, Discount = 0, ImgUrl = "civ6.jpg", Developer = "Firaxis Games", PublisherId = 3, ReleaseDate = new DateTime(2016, 10, 21), Platform = "PC" },
                new Game { Id = 6, GameName = "The Sims 4", CategoryId = 5, Description = "A life simulation game", Price = 49.99M, Discount = 0, ImgUrl = "sims4.jpg", Developer = "Maxis", PublisherId = 4, ReleaseDate = new DateTime(2014, 9, 2), Platform = "PC" },
                new Game { Id = 7, GameName = "Dark Souls III", CategoryId = 3, Description = "An action RPG game", Price = 59.99M, Discount = 0, ImgUrl = "darksouls3.jpg", Developer = "FromSoftware", PublisherId = 5, ReleaseDate = new DateTime(2016, 4, 12), Platform = "PC" },
                new Game { Id = 8, GameName = "Minecraft", CategoryId = 5, Description = "A sandbox game", Price = 26.95M, Discount = 0, ImgUrl = "minecraft.jpg", Developer = "Mojang", PublisherId = 6, ReleaseDate = new DateTime(2011, 11, 18), Platform = "PC" },
                new Game { Id = 9, GameName = "Fortnite", CategoryId = 1, Description = "A battle royale game", Price = 0M, Discount = 0, ImgUrl = "fortnite.jpg", Developer = "Epic Games", PublisherId = 7, ReleaseDate = new DateTime(2017, 7, 21), Platform = "PC" },
                new Game { Id = 10, GameName = "Stardew Valley", CategoryId = 2, Description = "A farming simulation game", Price = 14.99M, Discount = 0, ImgUrl = "stardewvalley.jpg", Developer = "ConcernedApe", PublisherId = 8, ReleaseDate = new DateTime(2016, 2, 26), Platform = "PC" }
            );
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id =1 , Name = "CD Projekt" },
                new Publisher { Id =2 , Name = "Rockstar Games" },
                new Publisher { Id =3 , Name = "2K Games" },
                new Publisher { Id =4 , Name = "Electronic Arts" },
                new Publisher { Id =5 , Name = "Bandai Namco Entertainment" },
                new Publisher { Id =6 , Name = "Mojang" },
                new Publisher { Id =7 , Name = "Epic Games" },
                new Publisher { Id =8 , Name = "ConcernedApe" }
                
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
