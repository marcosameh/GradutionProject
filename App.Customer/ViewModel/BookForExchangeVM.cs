using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewModel
{
   public class BookForExchangeVM
    {
        public int ExchageBookId { get; set; }
        [Required( ErrorMessage = "UrlName is requred")]
        [StringLength(70)]
        public string UrlName { get; set; }
        [Required(ErrorMessage = "Author Name is requred")]

        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Name is requred")]
        [StringLength(70)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is requred")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Range(1, 100, ErrorMessage = "Invalid Number of Copies")]
        public int? NumberOfCopies { get; set; }
        [Required(ErrorMessage = "Photo is requred")]
        [StringLength(70)]
        public string Photo { get; set; }
        public int? CopyYear { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string PdfUrl { get; set; }
        [StringLength(50)]
        public string AduioUrl { get; set; }
        public string PhotoPath { get { return "/photos/books/" + Photo; } }
        public IFormFile PhotoFile { get; set; }
        public string OwnerId { get; set; }

        public IFormFile AudioFile { get; set; }
        public IFormFile PdfFile { get; set; }


    }
}
