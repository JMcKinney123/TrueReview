using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }

        public string Synopsis { get; set; }

        public double RatingNumber { get; set; }

        public Genre.Genres GenreName { get; set; }

    }
}
