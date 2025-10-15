using System;
using LibrarySystem.Models;
using LibrarySystem.Data;

using Microsoft.EntityFrameworkCore;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Loan> Loans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfig());
        modelBuilder.ApplyConfiguration(new AuthorConfig());
        modelBuilder.ApplyConfiguration(new CategoryConfig());
        modelBuilder.ApplyConfiguration(new LoanConfig());
    }
}