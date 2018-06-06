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


        public int ReviewId { get; set; }
          
        public int GoodReadId { get; set; }

        public string UserName { get; set; }
        public string BookReview { get; set; }
        public string Title { get; set; }
        
        
        
        public Rating RatingNumber { get; set; }
        public Book Book { get; set; }

        public int GenreId { get; set; }
        public Genre.Genres GenreName { get; set; }

        

        

        



    }
}
