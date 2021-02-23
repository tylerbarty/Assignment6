using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        ISBN = "978-0451419439",
                        Title = "Les Miserables",
                        AuthorFName = "Victor",
                        AuthorLName = "Hugo",
                        Publisher = "Signet",
                        Classification = "Non-Fiction",
                        Category = "Classic",
                        Price = 9.95F
                    },
                    new Project
                    {
                        ISBN = "978-0743270755",
                        Title = "Team of Rivals",
                        AuthorFName = "Doris",
                        AuthorLName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58F
                    },
                    new Project
                    {
                        ISBN = "978-0553384611",
                        Title = "The Snowball",
                        AuthorFName = "Alice",
                        AuthorLName = "Schroeder",
                        Publisher = "Bantam",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54F
                    },
                    new Project
                    {
                        ISBN = "978-0812981254",
                        Title = "American Ulysses",
                        AuthorFName = "Ronald",
                        AuthorLName = "White",
                        Publisher = "Random House",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61F
                    },
                    new Project
                    {
                        ISBN = "978-0812974492",
                        Title = "Unbroken",
                        AuthorFName = "Laura",
                        AuthorLName = "Hillenbrand",
                        Publisher = "Random House",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33F
                    },
                    new Project
                    {
                        ISBN = "978-0804171281",
                        Title = "The Great Train Robbery",
                        AuthorFName = "Micheal",
                        AuthorLName = "Crichton",
                        Publisher = "Vintage",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95F
                    },
                    new Project
                    {
                        ISBN = "978-1455586691",
                        Title = "Deep Work",
                        AuthorFName = "Cal",
                        AuthorLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99F
                    },
                    new Project
                    {
                        ISBN = "978-1455523023",
                        Title = "It's Your Ship",
                        AuthorFName = "Michael",
                        AuthorLName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 29.66F
                    },
                    new Project
                    {
                        ISBN = "978-1591847984 ",
                        Title = "The Virgin Way",
                        AuthorFName = "Richard",
                        AuthorLName = "Branson",
                        Publisher = "Portfolio",
                        Classification = "Non-Fiction",
                        Category = "Buisness",
                        Price = 29.16F
                    },
                    new Project
                    {
                        ISBN = "978-0553393613",
                        Title = "Sycamore Row",
                        AuthorFName = "Josh",
                        AuthorLName = "Grisham",
                        Publisher = "Bantam",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03F
                    }

                );

                context.SaveChanges();

            }
        }
    }
}
