﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SharedTenant.Models
{
    public partial class BooksForExchange
    {
        public BooksForExchange()
        {
            CustomerRecomendedBook = new HashSet<CustomerRecomendedBook>();
            ExchangeBookCategoryList = new HashSet<ExchangeBookCategoryList>();
        }

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

        public virtual ICollection<CustomerRecomendedBook> CustomerRecomendedBook { get; set; }
        public virtual ICollection<ExchangeBookCategoryList> ExchangeBookCategoryList { get; set; }
    }
}