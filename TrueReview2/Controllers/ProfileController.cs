using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrueReview2.Models;
using TrueReview2.Data;
using TrueReview2.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrueReview2.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> _userManager;
        
        // GET: /<controller>/

        public ProfileController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            this.context = dbContext;
           

    }
        
        public IActionResult Index()
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);
            //var email = user.Email;

             //List<Profile> Profiles = context.Profiles.ToList();

            var email = User.Identity.Name;
            var userProfile = context.Profiles.Where(p => p.UserName == email); //.FirstOrDefault();

            //var userProfile = context.Profiles.Single(p => p.ApplicationUser.Email == email);



            return View(userProfile);

        }
        
        public IActionResult Create()
        {
            ProfileViewModel userProfileViewModel = new ProfileViewModel();
            return View(userProfileViewModel);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create(ProfileViewModel userProfileViewModel)
        {
            if (ModelState.IsValid)
            {
                Profile newProfile = new Profile
                {
                    Title = userProfileViewModel.Title,
                    UserName = User.Identity.Name,
                    AboutMe = userProfileViewModel.AboutMe,
                    

                };

                
                context.Profiles.Add(newProfile);

                context.SaveChanges();



                return Redirect("/Profile?=" + newProfile.ProfileId);
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
                Profile theProfile = context.Profiles.Single(c => c.ProfileId == profileId);
                context.Profiles.Remove(theProfile);
            }

            context.SaveChanges();

            return Redirect("/Profile/");
        }

        
       
    }
}
