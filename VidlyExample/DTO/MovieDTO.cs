using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using VidlyExample.Models;

namespace VidlyExample.DTO
{
    public class MovieDTO
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public byte StockNumber { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}