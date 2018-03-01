using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Genre
    {

        public int ID { get; set; }
        public string GenreName { get; set; }

       
        public int GenreId { get; set; }
        public enum Genres
        {

            ActionAdventure,
            Romance,
            Biography,
            NonFiction,
            Horror,
            Science,
            ScienceFiction,
            Mystery,
            Fantasy,
            Drama
        }
        

        public ICollection<Genres> GenreNames = new List<Genres>();
    }
}
