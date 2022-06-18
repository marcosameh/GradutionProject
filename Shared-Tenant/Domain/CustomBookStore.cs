using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTenant.Models
{
    [MetadataType(typeof(CustomBookStore))]
    public partial class BookStores
    {
        [NotMapped]
        public IFormFile PhotoFile { get; set; }

        [NotMapped]
        public string Email { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(30, ErrorMessage = "Must be between 6 and 30 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(30, ErrorMessage = "Must be between 6 and 30 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
    public  class CustomBookStore
    {
        [Required]
        public string Domain { get; set; }
        [Required]
        public string ConnectionString { get; set; }
        [Required]
        public string UrlName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime EndSubscriptionDate { get; set; }

       

    }
}
