using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Profile
    {
        
        public int ID { get; set; }
        public string UserName { get; set; }
        public string AboutMe { get; set; }
        public ApplicationUser ReviewAuthor { get; set; }

        public string Title { get; set; }
       
    }
}
