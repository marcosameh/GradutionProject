using App.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Librarian.ViewModels
{
    
    public class AuthorsVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Author Name Required")]
        [MinLength(3, ErrorMessage = "Invalid Name")]
        [MaxLength(25, ErrorMessage = "Invalid Name")]

        public string Name { get; set; }

      
        public string Photo { get; set; }
        public int DisplayOrder { get; set; }
      
        [NotMapped]
        [Required(ErrorMessage = "Photo Is Required")]
        public IFormFile PhotoFile { get; set; }
        [NotMapped]
        public string PhotoPath { get {return "/photos/author/"+Photo; } }

        [Required(ErrorMessage = "Author Info Required")]
        [MinLength(20, ErrorMessage = "Author info must be at least 25 words")]
        [MaxLength(300, ErrorMessage = "Author info must be at most 50 words")]

        public string Bio { get; set; }
        [Required]
        [Range(1,100,ErrorMessage ="Invalid Number")]
        public int NumberOfBooks { get; set; }
    }
}
