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
        [Required(ErrorMessage = "Number of copies is requred")]
        [Range(1, 100, ErrorMessage = "Invalid Number of Copies")]
        public int? NumberOfCopies { get; set; }
        [Required(ErrorMessage = "Photo is requred")]
        [StringLength(70)]
        public string Photo { get; set; }
        [Required(ErrorMessage = "copy year is requred")]
        [Range(1000,2022 , ErrorMessage = "Invalid Number of copy year")]
        public int? CopyYear { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(50)]
        public string PdfUrl { get; set; }
        [StringLength(50)]
        public string AduioUrl { get; set; }
        public string PhotoPath { get { return "/photos/books/" + Photo; } }
        [Required(ErrorMessage = "photo is requred")]
        public IFormFile PhotoFile { get; set; }
        public string OwnerId { get; set; }

        public IFormFile AudioFile { get; set; }
        public IFormFile PdfFile { get; set; }


    }
}
