using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTenant.Models
{
    [MetadataType(typeof(CustomBookStore))]
    public partial class BookStores
    {

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

        public IFormFile PhotoFile { get; set; }

    }
}
