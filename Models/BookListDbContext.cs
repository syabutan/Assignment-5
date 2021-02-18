using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class BookListDbContext : DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
