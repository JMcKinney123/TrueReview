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
    public class BookViewModel
    {
        [Required]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }

        
        [Display(Name = "ISBN")]
        public long ISBN { get; set; }


        [Display(Name = "Genre")]
        public Genre.Genres GenreName { get; set; }

        public double RatingNumber { get; set; }

        public List<SelectListItem> GenreNames { get; set; }


        public BookViewModel()
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
