using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static TrueReview2.Models.Genre;

namespace TrueReview2.Models
{
    public class Review
    {
        public int ID { get; set; }

        public Book BookId { get; set; }

        public int ReviewId { get; set; }
        
        public string BookReview { get; set; }
        public string Title { get; set; }

        public string UserName { get; set; }
        public int RatingId { get; set; }
        public double RatingNumber { get; set; }

        public int GenreId { get; set; }
        public Genre.Genres GenreName { get; set; }

        public ICollection<Genre> GenreNames { get; set; }

        public ICollection<Rating> RatingNumbers { get; set; }

        



    }
}
