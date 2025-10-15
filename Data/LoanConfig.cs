using System;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class LoanConfig : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.BorrowerName).IsRequired().HasMaxLength(100);
        builder.Property(l => l.LoanDate).IsRequired();
        builder.HasOne(l => l.Book)
               .WithMany()
               .HasForeignKey(l => l.BookId);
    }
}