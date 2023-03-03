using FlowerShop.EF.Models;
using FlowerShop.EF.SeedData;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasMany(x => x.Products)
                .WithMany(x => x.Carts)
                .UsingEntity<CartProducts>(
                    y => y
                        .HasOne(x => x.Product)
                        .WithMany(x => x.CartProducts)
                        .HasForeignKey(x => x.ProductId),
                    y => y
                        .HasOne(x => x.Cart)
                        .WithMany(x => x.CartProducts)
                        .HasForeignKey(x => x.CartId));

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
