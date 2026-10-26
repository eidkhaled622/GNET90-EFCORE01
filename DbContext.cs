using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Models;
using System.ComponentModel;
using EFTask1.Models;

namespace EFTask1
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=Library;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    firstName = "George",
                    lastName = "Orwell",
                    Email = "george.orwell@example.com",
                    Bio = "English novelist and essayist, author of 1984 and Animal Farm.",
                    DOB = new DateTime(1903, 6, 25),
                    Country = "United Kingdom"
                },
                new Author
                {
                    Id = 2,
                    firstName = "Jane",
                    lastName = "Austen",
                    Email = "jane.austen@example.com",
                    Bio = "English novelist known for her novels about the British gentry.",
                    DOB = new DateTime(1775, 12, 16),
                    Country = "United Kingdom"
                },
                new Author
                {
                    Id = 3,
                    firstName = "Naguib",
                    lastName = "Mahfouz",
                    Email = "naguib.mahfouz@example.com",
                    Bio = "Egyptian writer and winner of the Nobel Prize in Literature.",
                    DOB = new DateTime(1911, 12, 11),
                    Country = "Egypt"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Fiction", description = "Novels and stories", isActive = true },
                new Category { id = 2, name = "Classic", description = "Classic literature", isActive = true },
                new Category { id = 3, name = "Science", description = "Science books", isActive = false }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { ID = 1, Title = "1984", ISBN = "978-0451524935", publishYear = "1949", published = true, AuthorId = 1, CategoryId = 1 },
                new Book { ID = 2, Title = "Animal Farm", ISBN = "978-0451526342", publishYear = "1945", published = true, AuthorId = 1, CategoryId = 2 },
                new Book { ID = 3, Title = "Pride and Prejudice", ISBN = "978-0141439518", publishYear = "1813", published = true, AuthorId = 2, CategoryId = 2 },
                new Book { ID = 4, Title = "Cairo Trilogy", ISBN = "978-0385264662", publishYear = "1956", published = true, AuthorId = 3, CategoryId = 1 }
            );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}