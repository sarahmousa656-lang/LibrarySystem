using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(100);
            builder.HasOne(b => b.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(b => b.AuthorId);
            builder.HasOne(b => b.Category)
                     .WithMany(c => c.Books)
                        .HasForeignKey(b => b.CategoryId);
        }
    }
}