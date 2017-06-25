using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace VidlyExample.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
       

        [Required]
        [Display(Name = "Date Movie Added")]
        public DateTime DateAdded { get; set; }
        

        [Required]
        [Display(Name = "Number in Stock")]
        public int StockNumber { get; set; }
        

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}