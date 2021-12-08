using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public enum Genre
    {
        Horror,
        Comedy,
        Drama,
        Action
    }
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        //There are many overloads to this attribute, but most annotations will allow you to put in your own error message
        //Max Length works for strings only 
        [MaxLength(10, ErrorMessage = "Error: Title Must be 10 characters long")]

        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Range(1880, 2021, ErrorMessage = "Error: Year must be between 1880 and 2021")]
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    }
}