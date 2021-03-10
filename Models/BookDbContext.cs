using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksite.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }

}
