using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Review
    {
        
        public int ID { get; set; }
        public int RatingId { get; set; }
        
        public int ReviewId { get; set; }
        private static int nextId = 1;

        public Genre.Genres GenreName { get; set; }
        public int GenreId { get; set; }

        public int RatingNumber { get; set; }

        public string BookReview { get; set; }
        public string Title { get; set; }

        public IList<Review> Reviews { get; set; }
        public Review()
        {
            ReviewId = nextId;
            nextId++;
        }
    }
}
