using BookstoreNew.Models;
using BookstoreNew.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BookStoreNew.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IBookStoreRepo<Book> _bookRepo;
        private readonly IBookStoreRepo<Author> _authorRepo;

        public AuthorController(ILogger<AuthorController> logger,
                IBookStoreRepo<Book> bookRepo,
                IBookStoreRepo<Author> authorRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
            _authorRepo = authorRepo;
        }
        // GET: AuthorController
        public IActionResult Author()
        {
            var authors = _authorRepo.List();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public IActionResult DetailsAuthor(int id)
        {
            var author = _authorRepo.Find(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public IActionResult CreateAuthor()
        {
            return View();
        }
        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAuthor(Author author)
        {
            _authorRepo.Add(author);
            return RedirectToAction(nameof(Author));
        }

        // GET: AuthorController/Edit/5
        public IActionResult EditAuthor(int id)
        {
            var author = _authorRepo.Find(id);
            return View(author);
        }
        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAuthor(int id, Author author)
        {
            _authorRepo.Update(id, author);
            return RedirectToAction(nameof(Author));
        }


        // GET: AuthorController/Delete/5
        public IActionResult DeleteAuthor(int id)
        {
            var author = _authorRepo.Find(id);
            return View(author);
        }
        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAuthor(int id, Author author)
        {
            _authorRepo.Delete(id);
            return RedirectToAction(nameof(Author));
        }

    }
}
