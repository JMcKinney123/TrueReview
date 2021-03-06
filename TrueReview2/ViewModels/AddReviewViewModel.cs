﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrueReview2.Models;
using static TrueReview2.Models.Genre;

namespace TrueReview2.ViewModels
{
    public class AddReviewViewModel
    {

        
        [Display(Name = "Review Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You must include a review of the book.")]
        [Display(Name = "Book Review")]
        public string BookReview { get; set; }

        public int GenreID { get; set; }

        
        [Display(Name = "Genre")]
        public Genre.Genres GenreName { get; set; }
        
        [Range(1, 10, ErrorMessage = "Must be between one and ten.")]
        [Display(Name = "Book Rating")]
        public Rating RatingNumber { get; set; }

        public List<SelectListItem> GenreNames { get; set; }


        public AddReviewViewModel()
        {

            GenreNames = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = ((int)Genres.ActionAdventure).ToString(),
                    Text = Genres.ActionAdventure.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Romance).ToString(),
                    Text = Genres.Romance.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.NonFiction).ToString(),
                    Text = Genres.NonFiction.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.ScienceFiction).ToString(),
                    Text = Genres.ScienceFiction.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Romance).ToString(),
                    Text = Genres.Romance.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Mystery).ToString(),
                    Text = Genres.Mystery.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Horror).ToString(),
                    Text = Genres.Horror.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Fantasy).ToString(),
                    Text = Genres.Fantasy.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Drama).ToString(),
                    Text = Genres.Drama.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Science).ToString(),
                    Text = Genres.Science.ToString()
                },

                new SelectListItem
                {
                    Value = ((int)Genres.Biography).ToString(),
                    Text = Genres.Biography.ToString()
                }

            };
        }
    }


}
