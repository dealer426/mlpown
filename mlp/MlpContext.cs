using Microsoft.EntityFrameworkCore;
using mlp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mlp
{
    public class MlpContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-VRNV90S\\SQLEXPRESS;Database=MLP;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    Content = "I love this pony!!",
                    ReviewerName = "Carl",
                    ProductId = 1,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 2,
                    Content = "I love to feed my pony!!",
                    ReviewerName = "Amelia",
                    ProductId = 2,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 3,
                    Content = "I love to ride my pony!!",
                    ReviewerName = "Colleen",
                    ProductId = 3,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 4,
                    Content = "I wish I had this pony!!",
                    ReviewerName = "Tim",
                    ProductId = 4,
                    Rating = 5.0,
                }

                );

            modelbuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Rainbow Dash",
                    Image = "rainbowdash.png",
                    Category = "Leader",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a strong Pony! Haaaaay!"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Fluttershy",
                    Image = "fluttershy.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a shy Pony... hello!"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Pinkie Pie",
                    Image = "pinkypie.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a fun Pony!!!"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Twilight Sparkle",
                    Image = "twilightsparkle.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am yet another pony, heya!"
                }
                       );
        }

    }


}
