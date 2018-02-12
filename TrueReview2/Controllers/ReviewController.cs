using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using TrueReview2.ViewModels;

namespace TrueReview2.Controllers
{

    public class ReviewController : Controller
    {

        static private List<Review> Reviews = new List<Review>();


        public IActionResult Index()
        {
            ViewBag.reviews = Reviews;
            return View();
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


                Reviews.Add(newReview);



                return Redirect("/Review");
            }
            return View(addReviewViewModel);
        }
    }
}