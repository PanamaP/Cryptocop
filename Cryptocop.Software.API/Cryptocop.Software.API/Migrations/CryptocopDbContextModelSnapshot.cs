﻿// <auto-generated />
using System;
using Cryptocop.Software.API.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cryptocop.Software.API.Migrations
{
    [DbContext(typeof(CryptocopDbContext))]
    partial class CryptocopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.JwtToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Blacklisted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("JwtTokens");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("CardHolderName")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("text");

                    b.Property<string>("MaskedCreditCard")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductIdentifier")
                        .HasColumnType("text");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.PaymentCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CardHolderName")
                        .HasColumnType("text");

                    b.Property<string>("CardNumber")
                        .HasColumnType("text");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentCards");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ProductIdentifier")
                        .HasColumnType("text");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.Address", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.Order", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.OrderItem", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.PaymentCard", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.ShoppingCart", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cryptocop.Software.API.Models.Entities.ShoppingCartItem", b =>
                {
                    b.HasOne("Cryptocop.Software.API.Models.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
