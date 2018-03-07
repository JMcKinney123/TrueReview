using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using Microsoft.AspNetCore.Identity;
using TrueReview2.Data;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.message = "Far too many people tend to remain within the comforts of what they know. They do" +
                " not like to venture outside the subcultures of which they are members. They do not find enjoyment " +
                "in seeking knowledge beyond what is familiar to them. I find this to be a significant problem in" +
                " our society. Christians, for example, should learn and understand Islam. Muslims should learn and " +
                "understand Judaism. We should all learn about differences that should not define us as an individual " +
                "but, unfortunately, too often do. The purpose of this website is to help users seek knowledge beyond" +
                " what they know and love and, hopefully, learn to appreciate differences.";

            return View();
        }

        public IActionResult About()
        {
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
