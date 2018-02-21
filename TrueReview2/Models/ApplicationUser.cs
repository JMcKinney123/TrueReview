using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrueReview2.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

       
        
        public string AboutMe { get; set; }
        public string Title { get; set; }

        public string ReviewAuthor { get; set; }
        [Key]
        public int ApplicationUserID { get; set; }
        public Review BookReview { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers = new List<ApplicationUser>();
        public ICollection<Review> Reviews = new List<Review>();
        
    }
}
