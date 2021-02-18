using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //It's template (what has to be done)
    public interface iBookListRepository
    {
        IQueryable<Book> Books { get; }
    }
}
