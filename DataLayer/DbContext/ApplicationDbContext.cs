using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Banner;
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
        public DbSet<DynamicPage> DynamicPages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Log> Logs { get; set; }

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

            modelBuilder.Entity<DynamicPage>()
                .HasQueryFilter(c => !c.IsDelete);

            modelBuilder.Entity<Banner>()
                .HasQueryFilter(c => !c.IsDelete);

            #region Seed Data

            modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 1,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = null,
                Title = "مدیریت سایت"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =2 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 1,
                Title = "مدیریت کاربران"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =3 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =2 ,
                Title = "افزودن کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 4,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 2,
                Title = "ویرایش کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 5,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 2,
                Title = "حذف کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =6 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 2,
                Title = "سفارشات کاربران"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =7 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 2,
                Title = "دسترسی کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =8 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 2,
                Title = "محصولات مورد علافه کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 13,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =1 ,
                Title = "مدیریت تماس با ما"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 15,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =13 ,
                Title = "حذف تماس با ما"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 16,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =13 ,
                Title = "پاسخ تماس با ما"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 17,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 1,
                Title = "مدیریت تیکت ها"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =18 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =17 ,
                Title = "افزودن تیکت"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 20,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =17 ,
                Title = "بستن تیکت"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =21 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =17 ,
                Title = "پاسخ به تیکت"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =22 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 1,
                Title = "میدیریت محصولات"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =23 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =22 ,
                Title = "افزودن محصول"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 24,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =22 ,
                Title = "مدیریت تصاویر محصول"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =25 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =22 ,
                Title = "مدیریت نظرات محصول"
            });
            modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 27,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =22 ,
                Title = "مدیریت تگ های محصول"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =28 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =22 ,
                Title = "ویرایش محصول"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 29,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 22,
                Title = "حذف محصول"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =30 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =1 ,
                Title = "مدیریت ویژگی ها"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =31 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =30 ,
                Title = "مدیریت مقادیر ویژگی ها"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =32 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 1,
                Title = "مدیریت دسته بندی محصولات"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =33 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 7,
                Title = "افزودن نقش کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 34,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = 7,
                Title = "حذف نقش کاربر"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 35,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =1 ,
                Title = "مدیریت نقش ها"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =36 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId =35 ,
                Title = "افزودن نقش"
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =37 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =38 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =39 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 40,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =414 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 42,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 43,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =44 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =45 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = 46,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id =47 ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            }); modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                Id = ,
                CreatDate = DateTime.Now,
                IsDelete = false,
                ParentId = ,
                Title = ""
            });
            #endregion
        }

    }
}
