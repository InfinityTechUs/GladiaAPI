﻿// <auto-generated />
using System;
using Api_gladia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_gladia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211128232756_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Api_gladia.Models.Address", b =>
                {
                    b.Property<int>("address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address_cep")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("address_city")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("address_complement")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("address_district")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("address_public_place")
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("address_uf")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("fk_user_id")
                        .HasColumnType("int");

                    b.HasKey("address_id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Api_gladia.Models.Category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("category_name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("category_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Api_gladia.Models.Items_Order", b =>
                {
                    b.Property<int>("fk_id_prod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fk_id_order")
                        .HasColumnType("int");

                    b.Property<int>("items_quant")
                        .HasColumnType("int");

                    b.Property<string>("items_subtotal")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("fk_id_prod");

                    b.ToTable("Items_Order");
                });

            modelBuilder.Entity("Api_gladia.Models.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fk_id_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("order_date")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("order_payment")
                        .HasColumnType("longtext");

                    b.Property<string>("order_shipping")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("order_status")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("order_total")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("order_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Api_gladia.Models.Product", b =>
                {
                    b.Property<int>("prod_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fk_category")
                        .HasColumnType("int");

                    b.Property<string>("prod_brand")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("prod_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("prod_img")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("prod_min_quant")
                        .HasColumnType("int");

                    b.Property<string>("prod_name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("prod_price")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("prod_quant")
                        .HasColumnType("int");

                    b.HasKey("prod_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Api_gladia.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fk_address_id")
                        .HasColumnType("int");

                    b.Property<string>("user_cpf")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("user_email")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("user_img")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("user_lvl")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("user_name")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("user_password")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("user_phone")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}