using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace mvc.ViewModels
{
    public class SquareRootViewModel
    {
        [Required]
        public double A { get; set; }
        
        [Required]
        public double B { get; set; }

        [Required]
        public double C { get; set; }

        public string X1 { get; set; }
        
        public string X2 { get; set; }
        
        public bool HasRoots { get; set; } = false; 
    }
}