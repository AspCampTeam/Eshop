using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Order;
using Domain.Models.Product;
using Domain.Models.Tickets;
using Domain.Models.Common;
using Domain.Models.Role;
using Domain.Models.FAQ;

namespace DataLayer.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ContactUss> ContactUss { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketMassages> TicketMassages { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureValue> FeatureValues { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductSelectedFeature> ProductSelectedFeatures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderDetailProductFeature> OrderDetailProductFeatures { get; set; }
        public DbSet<DynamicLink> DynamicLinks { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<FAQ> FAQs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);

            modelBuilder.Entity<ProductCategory>()
                .HasQueryFilter(u => !u.IsDelete);

            modelBuilder.Entity<TicketMassages>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Ticket>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<ContactUss>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Product>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<ProductTag>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<ProductGallery>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<ProductSelectedCategory>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<ProductComment>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<FavoriteProduct>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Feature>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<FeatureValue>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<ProductPrice>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<ProductSelectedFeature>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Order>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<OrderDetail>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<DynamicLink>()
                .HasQueryFilter(c => !c.IsDelete);
            
            modelBuilder.Entity<SocialMedia>()
                .HasQueryFilter(c => !c.IsDelete);


            modelBuilder.Entity<Permission>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Role>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<UserRoles>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<FAQ>()
                .HasQueryFilter(c => !c.IsDelete);
        }

    }
}
