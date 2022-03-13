using App.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.ViewModels
{
    
    public class BookVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Book Name Required")]
        [MinLength(3, ErrorMessage = "Invalid Name")]
        [MaxLength(25, ErrorMessage = "Invalid Name")]

        public string Name { get; set; }
        [Required(ErrorMessage ="Book Price Required")]
        [Range(10,500,ErrorMessage ="price of book is from 10:500$")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Number Of Copies is Required")]
        [Range(1,100,ErrorMessage ="the range of copies from 1 to 100 only")]
        public int NumberOfCopies { get; set; }
        [Required(ErrorMessage ="Book Photo Required")]

        public string BookPhoto { get; set; }
        public string AuthorName { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Photo Is Required")]
        public IFormFile PhotoFile { get; set; }
        [NotMapped]
        public string PhotoPath { get { return "/photos/Books/" + BookPhoto; } }

        [Required(ErrorMessage = "Author Info Required")]
        [MinLength(20, ErrorMessage = "Book info must be at least 25 words")]
        [MaxLength(300, ErrorMessage = "Book info must be at most 50 words")]

        public string Bio { get; set; }
 
    }
}
