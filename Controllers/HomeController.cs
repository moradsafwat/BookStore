using BookstoreNew.Models;
using BookstoreNew.Repositories;
using BookStoreNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookStoreRepo<Book> _bookRepo;
        private readonly IBookStoreRepo<Author> _authorRepo;


        public HomeController(ILogger<HomeController> logger,
                IBookStoreRepo<Book> bookRepo,
                IBookStoreRepo<Author> authorRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
            _authorRepo = authorRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Privacy()
        {
            return View();
        }
     
        public IActionResult Images()
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
