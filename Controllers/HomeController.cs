using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models.ViewModels;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private iBookListRepository _repository;

        //Set how many items to show in a single page
        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, iBookListRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        //Show only "PageSize" items in a single page
        public IActionResult Index(string category, int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                        .Where(p => category == null || p.Category == category)
                        .OrderBy(p => p.BookId)
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize)
                    ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Books.Count() : 
                        _repository.Books.Where(x => x.Category == category).Count()
                },
                Category = category
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
