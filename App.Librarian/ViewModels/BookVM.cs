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
        
        public decimal BookPriceAfterDiscount
        {
            get
            {
                return (decimal)(Offer < 1 ? Price - (Price * Convert.ToDecimal(Offer)) : Price - Convert.ToDecimal(Offer));
            }
        }
        public IFormFile PhotoFile { get; set; }
        public string PhotoPath { get { return "/photos/books/" + Photo; } }
       
    }
}
