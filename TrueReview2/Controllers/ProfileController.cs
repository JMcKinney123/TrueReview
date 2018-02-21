using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using TrueReview2.Data;
using TrueReview2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrueReview2.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext context;
       
        // GET: /<controller>/

        public ProfileController(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Index()
        {
            List<Profile> Profiles = context.Profiles.ToList();

            return View(Profiles);
 
        }

        public IActionResult Create()
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            return View(userProfileViewModel);
        }

        [HttpPost]
        public IActionResult Create(UserProfileViewModel userProfileViewModel)
        {
            if (ModelState.IsValid)
            {
                Profile newProfile = new Profile
                {
                    Title = userProfileViewModel.Title,
                    UserName = userProfileViewModel.UserName,
                    AboutMe = userProfileViewModel.AboutMe,
                    

                };

                
                    context.Profiles.Add(newProfile);

                    context.SaveChanges();
                

                return Redirect(String.Format("/Profile?={0}", newProfile.ID));
            }
            return View(userProfileViewModel);
        }
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Profile(s)";
            ViewBag.profiles = context.Profiles.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] profileIds)
        {
            foreach (int profileId in profileIds)
            {
                Profile theProfile = context.Profiles.Single(c => c.ID == profileId);
                context.Profiles.Remove(theProfile);
            }

            context.SaveChanges();

            return Redirect("/Profile/");
        }
       
   
    }
}
