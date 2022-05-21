using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewModel
{
    public class ExchangeBookCategoryVM
    {
        [Required(ErrorMessage ="must select at leaset two categories")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPhoto { get; set; }
        public IFormFile PhotoFile { get; set; }
        public string PhotoPath { get { return "/photos/category/" + CategoryPhoto; } }

    }
}
