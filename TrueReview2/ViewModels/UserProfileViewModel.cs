using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueReview2.Models;

namespace TrueReview2.ViewModels
{
    public class UserProfileViewModel
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string AboutMe { get; set; }
        public Review ReviewAuthor { get; set; }


        public ICollection<Review> Reviews = new List<Review>();
    }
}
