using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Book
    {
        public int ID { get; set; }

        public int BookId { get; set; }

        public string Title { get; set; }
    }
}
