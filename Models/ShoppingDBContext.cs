using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_ShoppingCart.Shared.Models
{
    public partial class ShoppingDBContext : DbContext
    {
        public ShoppingDBContext()
        {
        }

        public ShoppingDBContext(DbContextOptions<ShoppingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ItemDetails> ItemDetails { get; set; }
        public virtual DbSet<ShoppingDetails> ShoppingDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= .;Database=ShoppingDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemDetails>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");               

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("Item_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnName("Item_Price");
            });

            modelBuilder.Entity<ShoppingDetails>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.Property(e => e.ShopId).HasColumnName("shopId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.ShoppingDate)
                    .HasColumnName("shoppingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
