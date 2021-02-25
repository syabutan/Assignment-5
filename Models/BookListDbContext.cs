using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //gives connection to the database
    public class BookListDbContext : DbContext
    {
        //inherite base, which is passing DbContext
        public BookListDbContext(DbContextOptions<BookListDbContext> options) : base(options)
        {

        }
        //set the variable as a database
        public DbSet<Book> Books { get; set; }
    }
}
