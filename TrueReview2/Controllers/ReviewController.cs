using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using TrueReview2.ViewModels;
using TrueReview2.Data;

namespace TrueReview2.Controllers
{

    public class ReviewController : Controller
    {

        private ApplicationDbContext context;

        public ReviewController(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Index()
        {
            List<Review> Reviews = context.Reviews.ToList();
            return View(Reviews);
        }

        public IActionResult Add()
        {
            AddReviewViewModel addReviewViewModel = new AddReviewViewModel();
            return View(addReviewViewModel);
        }

        [HttpPost]

        public IActionResult Add(AddReviewViewModel addReviewViewModel)
        {
            if (ModelState.IsValid)
            {
                Review newReview = new Review
                {
                    Title = addReviewViewModel.Title,
                    BookReview = addReviewViewModel.BookReview,
                    GenreName = addReviewViewModel.GenreName,
                    RatingNumber = addReviewViewModel.RatingNumber,

                };


                context.Reviews.Add(newReview);
                context.SaveChanges();


                return Redirect("/Review");
            }
            return View(addReviewViewModel);
        }
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Review(s)";
            ViewBag.reviews = context.Reviews.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] reviewIds)
        {
            foreach (int reviewId in reviewIds)
            {
                Review theReview = context.Reviews.Single(c => c.ID == reviewId);
                context.Reviews.Remove(theReview);
            }

            context.SaveChanges();

            return Redirect("/Review");
        }
    }
}