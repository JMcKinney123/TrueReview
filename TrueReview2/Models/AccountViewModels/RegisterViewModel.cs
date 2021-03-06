﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static TrueReview2.Models.Genre;

namespace TrueReview2.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public Genre.Genres GenreName { get; set; }

        public List<SelectListItem> GenreNames { get; set; }


        public RegisterViewModel()
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
