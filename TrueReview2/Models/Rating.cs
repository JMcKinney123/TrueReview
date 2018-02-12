using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Rating
    {
        public int ID { get; set; }
        
        public int RatingId { get; set; }

        public int RatingNumber { get; set; }
        
    }
}
