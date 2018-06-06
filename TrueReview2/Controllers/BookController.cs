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
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["AuthorSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Author" : "";
            ViewData["CurrentFilter"] = searchString;

            var books = from s in context.Books
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.ToUpper().Contains(searchString.ToUpper())
                                       || s.Author.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    books = books.OrderByDescending(s => s.Title);
                    break;
                case "Author":
                    books = books.OrderBy(s => s.Author);
                    break;
                
                default:
                    books = books.OrderBy(s => s.Title);
                    break;
            }
            return View(await books.AsNoTracking().ToListAsync());
        }





       /* public IActionResult Index()
        {
            List<Book> Books = context.Books.ToList();
            return View(Books);
        } */

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
                    RatingNumber = bookViewModel.RatingNumber,

                };

                var title = newBook.Title;
                var author = newBook.Author;

                var numBook = context.Books.Where(x => x.Title == title && x.Author == author).ToList().Count;

                if (numBook >= 1)
                {
                    return Redirect("/Book/Index");
                }
                else
                {

                    context.Books.Add(newBook);
                    context.SaveChanges();
                    return Redirect("/Book/Results/" + newBook.BookId);
                }


                
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
        public IActionResult Results(int id)
        {
          

            var bookPage = context.Books.Where(p => p.BookId == id);


            return View(bookPage);


        }
    }
}