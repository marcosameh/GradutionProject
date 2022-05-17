using App.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.ViewModels
{
    public class BookVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string UrlName { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        [Range(1, 100, ErrorMessage = "Invalid Number of Copies")]

        public int? NumberOfCopies { get; set; }
         [Range(20,1000,ErrorMessage ="Invalid Price")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(70)]
        public string Photo { get; set; }
        public int CopyYear { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [StringLength(50)]
        public string PdfUrl { get; set; }
        [StringLength(50)]
        public string AduioUrl { get; set; }
        public double? Offer { get; set; }
        
        public string BookPriceAfterDiscount
        {
            get
            {
                decimal price1 = Price - (Price * Convert.ToDecimal(Offer));
                decimal price0 = Price - Convert.ToDecimal(Offer);
                return Offer < 1 ? price1.ToString("####") :price0.ToString("####") ;
            }
        }
        public IFormFile PhotoFile { get; set; }
        public string PhotoPath { get { return "/photos/books/" + Photo; } }
        public string AuthorPhoto { get; set; }
        public string AuthorPhotoPath { get { return "/photos/author/" + AuthorPhoto; } }
        public IFormFile AudioFile { get; set; }
        public IFormFile PdfFile { get; set; }
   
      

    }
}
