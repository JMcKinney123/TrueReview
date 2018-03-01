using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrueReview2.Models
{
    public class Rating
    {
        
        public double RatingNumber { get; set; }
        public int RatingId { get; set; }

        public int ReviewId { get; set; }

        public Rating() { }

        public static double TrueRating(double[] RatingNumber)
        {
            double sum = 0;

            for (int i = 0; i < RatingNumber.Length; i++)
            {
                sum += RatingNumber[i];
            }

            double rating = sum / RatingNumber.Length;

            return rating;
        }

    }

   
}
