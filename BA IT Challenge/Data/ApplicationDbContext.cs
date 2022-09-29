using BA_IT_Challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BA_IT_Challenge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>()
                .HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "Dead Poets Society",
                        Author = "Nancy H. Kleinbaum",
                        Publisher = "Disney Press",
                        PublishDate = "1988",
                        Genre = "Fiction",
                        ISBN = "4567876543678",
                        Status = "Available",
                        LenderOrReserverId = null
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "How to Win Friends and Influence People",
                        Author = "Dale Carnegie",
                        Publisher = "Simon & Schuster",
                        PublishDate = "1936",
                        Genre = "Self-help",
                        ISBN = "9876567098764",
                        Status = "Available",
                        LenderOrReserverId = null
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Fight Club",
                        Author = "Chuck Palahniuk",
                        ISBN = "4567876543442",
                        Status = "Available",
                        LenderOrReserverId = null
                    }
                );
        }
    }
}