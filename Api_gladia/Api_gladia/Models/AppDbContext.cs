using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Address> tbl_address { get; set; }
        public DbSet<Category> tbl_category { get; set; }
        public DbSet<Order> tbl_order { get; set; }
        public DbSet<Items_Order> tbl_items_order { get; set; }
        public DbSet<Product> tbl_product { get; set; }
        public DbSet<User> tbl_user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Address Id
            modelBuilder.Entity<Address>()
                .HasKey(k => k.address_id);
            // Address Cep
            modelBuilder.Entity<Address>()
                .Property(p => p.address_cep)
                .HasMaxLength(8);
            // Address Uf
            modelBuilder.Entity<Address>()
                .Property(p => p.address_uf)
                .HasMaxLength(2);
            // Address City
            modelBuilder.Entity<Address>()
                .Property(p => p.address_city)
                .HasMaxLength(80);
            // Address District
            modelBuilder.Entity<Address>()
                .Property(p => p.address_district)
                .HasMaxLength(80);
            // Address Public Place
            modelBuilder.Entity<Address>()
                .Property(p => p.address_public_place)
                .HasMaxLength(120);
            // Address Complement
            modelBuilder.Entity<Address>()
                .Property(p => p.address_complement)
                .HasMaxLength(80);
            // Address FK User Id
            modelBuilder.Entity<Address>()
                .Property(p => p.fk_user_id);

            // Category Id
            modelBuilder.Entity<Category>()
                .HasKey(k => k.category_id);
            // Category Name
            modelBuilder.Entity<Category>()
                .Property(p => p.category_name)
                .HasMaxLength(50);

            // Order Id
            modelBuilder.Entity<Order>()
                .HasKey(k => k.order_id);
            // Order Date
            modelBuilder.Entity<Order>()
                .Property(p => p.order_date)
                .HasMaxLength(255);
            // Order Subtotal
            modelBuilder.Entity<Order>()
                .Property(p => p.order_status)
                .HasMaxLength(2); 
            // Order Total
            modelBuilder.Entity<Order>()
                .Property(p => p.order_total)
                .HasMaxLength(25);
            // Order Payment
            modelBuilder.Entity<Order>()
                .Property(p=> p.order_payment);
            // Order Shipping
            modelBuilder.Entity<Order>()
                .Property(p => p.order_shipping)
                .HasMaxLength(255);
            // Order Fk id User
            modelBuilder.Entity<Order>()
                .Property(p => p.fk_id_user);

            //Product Id
            modelBuilder.Entity<Product>()
                .HasKey(k=> k.prod_id);
            // Product Name
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_name)
                .HasMaxLength(100);
            // Product Description
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_desc);
            // Product Brand
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_brand)
                .HasMaxLength(80);
            //Product Price
            modelBuilder.Entity<Product>()
                .Property(k => k.prod_price)
                .HasMaxLength(255);
            // Product Quantity
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_quant);
            // Product Image
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_img)
                .HasMaxLength(255); 
            // Product Brand
            modelBuilder.Entity<Product>()
                .Property(p => p.prod_min_quant);
            // Product FK Category
            modelBuilder.Entity<Product>()
                .Property(p => p.fk_category);

            // User Id
            modelBuilder.Entity<User>()
                .HasKey(k => k.user_id);
            // User Name
            modelBuilder.Entity<User>()
                .Property(p => p.user_name)
                .HasMaxLength(80);
            // User Cpf
            modelBuilder.Entity<User>()
                .Property(p => p.user_cpf)
                .HasMaxLength(11);
            // User Phone
            modelBuilder.Entity<User>()
                .Property(p => p.user_phone)
                .HasMaxLength(11);
            // User Email
            modelBuilder.Entity<User>()
                .Property(p => p.user_email)
                .HasMaxLength(80); 
            // User Password
            modelBuilder.Entity<User>()
                .Property(p => p.user_password)
                .HasMaxLength(80);
            // User Imagem
            modelBuilder.Entity<User>()
                .Property(p => p.user_img)
                .HasMaxLength(255); 
            // User Level
            modelBuilder.Entity<User>()
                .Property(p => p.user_lvl)
                .HasMaxLength(2);
            // User Fk Address Id
            modelBuilder.Entity<User>()
            .Property(p => p.fk_address_id);


            //Items Order FK Id Order
            modelBuilder.Entity<Items_Order>()
            .HasKey(k => k.fk_id_order);
            //Items Order Fk Id prod
            modelBuilder.Entity<Items_Order>()
            .HasKey(k => k.fk_id_prod);
            // Items Order Quantity
            modelBuilder.Entity<Items_Order>()
                .Property(p => p.items_quant);
            // Items Order Subtotal
            modelBuilder.Entity<Items_Order>()
                .Property(p => p.items_subtotal)
                .HasMaxLength(255);

        }
    }
}
