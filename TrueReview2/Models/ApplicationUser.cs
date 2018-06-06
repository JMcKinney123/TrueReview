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

       
        public Genre.Genres GenreName { get; set; }

        public ICollection<Genre> GenreNames { get; set; }
        
        public ICollection<Review> Reviews { get; set; }
       
      
        
        
    }
}
