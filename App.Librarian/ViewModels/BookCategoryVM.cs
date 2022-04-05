using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.ViewModels
{
    public class BookCategoryVM
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
