using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using Microsoft.AspNetCore.Identity;
using TrueReview2.Data;

namespace TrueReview2.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext context;

        public HomeController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            this.context = dbContext;
        }

        public IActionResult Index()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        public async Task<ActionResult> About()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);

            if (currentUser != null)
            {
                ViewData["Message"] = "Welcome " + currentUser.UserName;
            }
            else
            {
                ViewData["Message"] = "Welcome, Guest User";
            }
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
