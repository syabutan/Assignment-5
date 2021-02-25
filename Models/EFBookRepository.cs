using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment5.Models
{
    public class EFBookRepository : iBookListRepository
    {
        //_context set as database
        private BookListDbContext _context;

        //Constructor
        public EFBookRepository (BookListDbContext context)
        {
            _context = context;
        }
        //Put everything in the list into dadtabase
        public IQueryable<Book> Books => _context.Books;
    }
}
