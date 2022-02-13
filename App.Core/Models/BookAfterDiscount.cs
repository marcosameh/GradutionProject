using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public partial class  Book
    {
        [NotMapped]
        public decimal BookPriceAfterDiscount{
            get
            {
            return (decimal)(Offer < 1? Price-(Price * Convert.ToDecimal(Offer)) : Price-Convert.ToDecimal(Offer));
            }
        }
    }
}
