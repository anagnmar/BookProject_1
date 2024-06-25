using Microsoft.EntityFrameworkCore;

using BookProject.Web.Models;


namespace BookProject.Web.DataAccess
{
    public class BookDbContext : DbContext
    {
        /*  
             public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
            {
            }
        */

        public BookDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Book>? Books { get; set; }




        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(" connectionString");

        }*/


        ///*
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1, Title = "Thief Of The South", Author = "James Patterson", Genre="Biography",ISBN="359-0-9921-2413-7"},
                new Book { Id = 2, Title = "Titan Retreating", Author = "Fyodor Dostoevsky", Genre = "Sci-fi", ISBN = "823-0-5471-0259-1" },
                new Book { Id = 3, Title = "He Stole My Knight", Author = "Oscar Wilde", Genre = "Romance", ISBN = "487-0-6398-9010-8" },
                new Book { Id = 4, Title = "Rescue At The Castle", Author = "James Joyce", Genre = "Mystery", ISBN = "143-0-2581-2591-4" },
                new Book { Id = 5, Title = "Made for Duty", Author = "Ernest Hemingway", Genre = "Crime", ISBN = "561-0-1795-1795-8" }
                );
        }
        //*/


    }

}
