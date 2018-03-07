using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    
     public class Profile 
    {

        

        public string UserName { get; set; }
        public string AboutMe { get; set; }
        public Genre.Genres GenreName { get; set; }

        public string ReviewAuthor { get; set; }
        public int ApplicationUserId { get; set; }

        public int ProfileId { get; set; }
        public string Title { get; set; }

        public Contact Contact { get; set; }
        public int ReviewId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
       
        public ICollection<Review> Reviews { get; set; }

        
    }
}