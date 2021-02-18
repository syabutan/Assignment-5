using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment5.Models
{
    public class EFBookRepository : iBookListRepository
    {
        private BookListDbContext _context;

        //Constructor
        public EFBookRepository (BookListDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
