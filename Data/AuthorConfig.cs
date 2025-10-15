using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(a => a.Books)
               .WithOne(b => b.Author)
               .HasForeignKey(b => b.AuthorId);
    }
}