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
using TrueReview2.Helper;
using System.Net.Http;
using Newtonsoft.Json;

namespace TrueReview2.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext context;

        GoodReadAPI _api = new GoodReadAPI();

        public HomeController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            this.context = dbContext;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var books = from m in context.Books
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString));
            }

            return View(await books.ToListAsync());

        }

        public async Task<IActionResult> IndexAPI()
        {
            List<GoodRead> goodRead = new List<GoodRead>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/GoodReads");


            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                goodRead = JsonConvert.DeserializeObject<List<GoodRead>>(result);
            }

                return View(goodRead);
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
