using LibrarySystem.Models;

namespace LibrarySystem.Data.Seeders
{
    public static class AuthorSeeder
    {
        public static void SeedAuthors(this LibraryContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Author { Name = "Mark Twain" },
                    new Author { Name = "Jane Austen" }
                );
                context.SaveChanges();
                Console.WriteLine("Seeded authors.");
            }
        }
    }
}
