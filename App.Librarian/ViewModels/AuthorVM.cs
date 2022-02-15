using App.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.ViewModels
{
    [AutoMap(typeof(Authors), ReverseMap = true)]
    public class AuthorsVM
    {

        [Required(ErrorMessage ="Author Name Required")]
        [MinLength(3,ErrorMessage = "Invalid Name")]
        [MaxLength(25,ErrorMessage = "Invalid Name")]
      
        public string Name { get; set; }
        [Required(ErrorMessage = "Photo Is Required")]
        public string Photo { get; set; }
        public int DisplayOrder { get; set; }
        public short? NumberOfBooks { get; set; }
    }
}
