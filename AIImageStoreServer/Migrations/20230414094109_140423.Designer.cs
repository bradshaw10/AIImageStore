﻿// <auto-generated />
using System;
using AIImageStoreServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AIImageStoreServer.Migrations
{
    [DbContext(typeof(AiImageStoreContext))]
    [Migration("20230414094109_140423")]
    partial class _140423
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AIImageStoreServer.Models.Cart", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("UserId", "ProductId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductId" }, "product_id");

                    b.ToTable("cart", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.HasKey("CategoryId")
                        .HasName("PRIMARY");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("billing_address");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("shipping_address");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("total_price");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("OrderId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "user_id");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("unit_price");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductId" }, "product_id")
                        .HasDatabaseName("product_id1");

                    b.ToTable("order_items", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<decimal>("Price")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("product_name");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("ProductId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductId" }, "products_index");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.PurchaseHistory", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime")
                        .HasColumnName("purchase_date");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("UserId", "OrderId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OrderId" }, "order_id");

                    b.HasIndex(new[] { "ProductId" }, "product_id")
                        .HasDatabaseName("product_id2");

                    b.ToTable("purchase_history", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("transaction_id");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime")
                        .HasColumnName("payment_date");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("payment_method");

                    b.HasKey("TransactionId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OrderId" }, "order_id")
                        .HasDatabaseName("order_id1");

                    b.ToTable("transactions", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("billing_address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varbinary(255)")
                        .HasColumnName("password_hash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varbinary(255)")
                        .HasColumnName("password_salt");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("shipping_address");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "username")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Cart", b =>
                {
                    b.HasOne("AIImageStoreServer.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("cart_ibfk_2");

                    b.HasOne("AIImageStoreServer.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("cart_ibfk_1");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Order", b =>
                {
                    b.HasOne("AIImageStoreServer.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("orders_ibfk_1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.OrderItem", b =>
                {
                    b.HasOne("AIImageStoreServer.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("order_items_ibfk_1");

                    b.HasOne("AIImageStoreServer.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("order_items_ibfk_2");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.PurchaseHistory", b =>
                {
                    b.HasOne("AIImageStoreServer.Models.Order", "Order")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("purchase_history_ibfk_2");

                    b.HasOne("AIImageStoreServer.Models.Product", "Product")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("purchase_history_ibfk_3");

                    b.HasOne("AIImageStoreServer.Models.User", "User")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("purchase_history_ibfk_1");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Transaction", b =>
                {
                    b.HasOne("AIImageStoreServer.Models.Order", "Order")
                        .WithMany("Transactions")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("transactions_ibfk_1");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("PurchaseHistories");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderItems");

                    b.Navigation("PurchaseHistories");
                });

            modelBuilder.Entity("AIImageStoreServer.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("PurchaseHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
