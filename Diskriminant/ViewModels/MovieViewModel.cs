using System;
using System.ComponentModel.DataAnnotations;

namespace mvc.ViewModels
{
    public class MovieViewModel
    {
        [Required]
        [MaxLength(54)]
        public string MovieName { get; set; }

        [Required]
        [MaxLength(40)]
        public string Country { get; set; }
        public string Genre { get; set; }
    }
}