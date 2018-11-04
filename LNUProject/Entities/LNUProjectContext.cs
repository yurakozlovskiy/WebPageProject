using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace LNUProject.Entities
{
    public partial class LNUProjectContext:DbContext
    {
        public LNUProjectContext() : base("LNUProjectContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CreateAddressReferences(modelBuilder);
            CreateCartReferences(modelBuilder);
            CreateCartgoodReferences(modelBuilder);
            CreateCategoryReferences(modelBuilder);
            CreateGoodReferences(modelBuilder);
            CreateRoleReferences(modelBuilder);
            CreateUserReferences(modelBuilder);
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Cartgood> Cartgoods { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Good> Goods { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        private void CreateAddressReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasKey(address => address.Id)
                .HasRequired(address => address.User)
                .WithMany(user => user.Addresses)
                .HasForeignKey(address => address.UserId)
                .WillCascadeOnDelete(false);
        }

        private void CreateCartReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasKey(cart => cart.Id)
                .HasRequired(cart => cart.User)
                .WithMany(user => user.Users)
                .HasForeignKey(cart => cart.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .HasRequired(cart => cart.Seller)
                .WithMany(user => user.Sellers)
                .HasForeignKey(cart => cart.SellerId)
                .WillCascadeOnDelete(false);
        }

        private void CreateCartgoodReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cartgood>()
                .HasKey(cartgood => cartgood.Id)
                .HasRequired(cartgood => cartgood.Good)
                .WithMany(good => good.Cartgoods)
                .HasForeignKey(cartgood => cartgood.GoodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cartgood>()
                .HasRequired(cartgood => cartgood.Cart)
                .WithMany(cart => cart.Cartgoods)
                .HasForeignKey(cartgood => cartgood.CartId)
                .WillCascadeOnDelete(false);
        }

        private void CreateCategoryReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(category => category.Id);
        }

        private void CreateGoodReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good>()
                .HasKey(good => good.Id)
                .HasRequired(good => good.Category)
                .WithMany(cartgood => cartgood.Goods)
                .HasForeignKey(good => good.CategoryId)
                .WillCascadeOnDelete(false);
                
        }

        private void CreateRoleReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasKey(role => role.Id);
        }

        private void CreateUserReferences(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(user => user.Id)
                .HasRequired(user => user.Role)
                .WithMany(role => role.Users)
                .HasForeignKey(user => user.RoleId)
                .WillCascadeOnDelete(false);
        }

    }
}
