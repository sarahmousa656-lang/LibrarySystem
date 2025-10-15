using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
        builder.HasMany(c => c.Books)
               .WithOne(b => b.Category)
               .HasForeignKey(b => b.CategoryId);
    }
}