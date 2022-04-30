﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SharedTenant.Domain;

#nullable disable

namespace SharedTenant.Models
{
    public partial class SharedtenantContext : IdentityDbContext<ApplicationUser>
    {
        public SharedtenantContext()
        {
        }

        public SharedtenantContext(DbContextOptions<SharedtenantContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookStores> BookStores { get; set; }
        public virtual DbSet<BooksForExchange> BooksForExchange { get; set; }
        public virtual DbSet<CustomerLoveCategory> CustomerLoveCategory { get; set; }
        public virtual DbSet<CustomerRecomendedBook> CustomerRecomendedBook { get; set; }
        public virtual DbSet<ExchangBookCategory> ExchangBookCategory { get; set; }
        public virtual DbSet<ExchangeBookCategoryList> ExchangeBookCategoryList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookStores>(entity =>
            {
                entity.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UrlName).HasMaxLength(150);
            });

            modelBuilder.Entity<BooksForExchange>(entity =>
            {
                entity.HasKey(e => e.ExchageBookId);

                entity.Property(e => e.AduioUrl).HasMaxLength(50);

                entity.Property(e => e.AuthorName).HasMaxLength(70);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(70);

                entity.Property(e => e.PdfUrl).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(70);

                entity.Property(e => e.UrlName).HasMaxLength(70);
            });

            modelBuilder.Entity<CustomerLoveCategory>(entity =>
            {
                entity.Property(e => e.CutomerId).HasMaxLength(450);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CustomerLoveCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerLoveCategory_ExchangBookCategory");
            });

            modelBuilder.Entity<CustomerRecomendedBook>(entity =>
            {
                entity.Property(e => e.CustomerId).HasMaxLength(450);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.CustomerRecomendedBook)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerRecomendedBook_BooksForExchange");
            });

            modelBuilder.Entity<ExchangBookCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CategoryPhoto).HasMaxLength(265);
            });

            modelBuilder.Entity<ExchangeBookCategoryList>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ExchangeBookCategoryList)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ExchangeBookCategoryList_BooksForExchange");

                entity.HasOne(d => d.Categroy)
                    .WithMany(p => p.ExchangeBookCategoryList)
                    .HasForeignKey(d => d.CategroyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ExchangeBookCategoryList_ExchangBookCategory");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}