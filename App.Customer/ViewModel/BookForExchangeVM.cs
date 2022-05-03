using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewModel
{
   public class BookForExchangeVM
    {
        public int ExchageBookId { get; set; }
        public string UrlName { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NumberOfCopies { get; set; }
        public string Photo { get; set; }
        public int? CopyYear { get; set; }
        public bool? IsActive { get; set; }
        public string PdfUrl { get; set; }
        public string AduioUrl { get; set; }
        public string PhotoPath { get { return "/photos/books/" + Photo; } }

    }
}
