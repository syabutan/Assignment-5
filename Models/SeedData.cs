﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        //IApplication handles http request
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            //connect database to http request
            BookListDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookListDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95F,
                        NumberOfPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58F,
                        NumberOfPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54F,
                        NumberOfPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61F,
                        NumberOfPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33F,
                        NumberOfPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95F,
                        NumberOfPages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "SignGrand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99F,
                        NumberOfPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66F,
                        NumberOfPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16F,
                        NumberOfPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03F,
                        NumberOfPages = 642
                    },

                    new Book
                    {
                        Title = "Seven Habits",
                        AuthorFirstName = "Steven",
                        AuthorMiddleName = "R.",
                        AuthorLastName = "Covey",
                        Publisher = "Free Press",
                        ISBN = "074-3269519000",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 30.05F,
                        NumberOfPages = 381
                    },

                    new Book
                    {
                        Title = "How to Win Friends and Influence People",
                        AuthorFirstName = "Dale",
                        AuthorLastName = "Carnegie",
                        Publisher = "Simon and Schuster",
                        ISBN = "143-9167346000",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 25.05F,
                        NumberOfPages = 291
                    },

                    new Book
                    {
                        Title = "The Vacishing Half",
                        AuthorFirstName = "Brit",
                        AuthorLastName = "Bennett",
                        Publisher = "Riverhead Books",
                        ISBN = "978-0525536291",
                        Classification = "Fiction",
                        Category = "Mystery",
                        Price = 27.05F,
                        NumberOfPages = 352
                    }
                );

                //save change in database context
                context.SaveChanges();
            }
        }
    }
}
