// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data;
using LibrarySystem.Models;
using LibrarySystem.Data.Seeders;
public class Program
{
    public static void Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseSqlite("Data Source=library.db")
            .Options;

        var context = new LibraryContext(options);
        context.Database.EnsureCreated();  
            var author = new Author { Name = "George Orwell" };
            context.Authors.Add(author);
            context.SaveChanges();
            var book = new Book { Title = "1984", AuthorId = author.Id };
            context.Books.Add(book);
            context.SaveChanges();
            var savedBook = context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == book.Id);
        Console.WriteLine($"Book: {savedBook.Title}, Author: {savedBook.Author.Name}");
        context.SeedAuthors();
        /*
    var transaction = context.Database.BeginTransaction();

try
{
    var author = new Author { Name = "J.K. Rowling" };
    var category = new Category { Name = "Fantasy" };
    var book = new Book
    {
        Title = "Harry Potter",
        ISBN = "12345",
        PublishYear = 1997,
        Author = author,
        Category = category
    };

    context.Authors.Add(author);
    context.Categories.Add(category);
    context.Books.Add(book);
    context.SaveChanges();

    transaction.Commit();
}
catch
{
    transaction.Rollback();
}

        */
    }
}
            