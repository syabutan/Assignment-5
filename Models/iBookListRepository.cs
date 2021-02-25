using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//repository is just setting a template

namespace Assignment5.Models
{
    //Interface is template (what has to be done)
    public interface iBookListRepository
    {
        //IQueryable handles lists
        IQueryable<Book> Books { get; }
    }
}
