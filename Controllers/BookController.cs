using BookstoreNew.Models;
using BookstoreNew.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreNew.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookStoreRepo<Book> _bookRepo;
        private readonly IBookStoreRepo<Author> _authorRepo;

        public BookController(ILogger<BookController> logger,
                IBookStoreRepo<Book> bookRepo,
                IBookStoreRepo<Author> authorRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
            _authorRepo = authorRepo;
        }
        // GET: BookController
        public IActionResult Books()
        {
            var books = _bookRepo.List();
            return View(books);
        }

        // GET: BookController/Details/5
        public IActionResult DetailsBook(int id)
        {
            var book = _bookRepo.Find(id);
            return View(book);
        }

        // GET: BookController/Create
        public IActionResult CreateBook()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBook(Book book)
        {
            _bookRepo.Add(book);
            return RedirectToAction(nameof(Books));
        }

        // GET: BookController/Edit/5
        public IActionResult EditBook(int id)
        {
            var book = _bookRepo.Find(id);
            return View(book);
        }
        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBook(int id, Book book)
        {
            _bookRepo.Update(id, book);
            return RedirectToAction(nameof(Books));
        }

        // GET: BookController/Delete/5
        public IActionResult DeleteBook(int id)
        {
            var book = _bookRepo.Find(id);
            return View(book);
        }
        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int id, Book book)
        {
            _bookRepo.Delete(id);
            return RedirectToAction(nameof(Books));
        }
    }
}
