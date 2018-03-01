using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Data;
using Microsoft.AspNetCore.Identity;
using TrueReview2.Models;
using TrueReview2.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace TrueReview2.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> _userManager;

        public BookController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.context = dbContext;
            _userManager = userManager;
            
        }
        public IActionResult Index()
        {
            List<Book> Books = context.Books.ToList();
            return View(Books);
        }

        public IActionResult Add()
        {
            BookViewModel bookViewModel = new BookViewModel();
            return View(bookViewModel);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Add(BookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                Book newBook = new Book
                {
                    Title = bookViewModel.Title,
                    Author = bookViewModel.Author,
                    ISBN = bookViewModel.ISBN,
                    GenreName = bookViewModel.GenreName,


                };


                context.Books.Add(newBook);

                context.SaveChanges();



                return Redirect("/Book?=" + newBook.BookId);
            }
            return View(bookViewModel);
        }
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Book(s)";
            ViewBag.books = context.Books.ToList();
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Remove(int[] bookIds)
        {
            foreach (int bookId in bookIds)
            {
                Book theBook = context.Books.Single(c => c.BookId == bookId);
                context.Books.Remove(theBook);
            }

            context.SaveChanges();

            return Redirect("/Book");
        }
    }
}