﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace App.Core.Models
{
    public partial class Book
    {
        public Book()
        {
            BookCategoryList = new HashSet<BookCategoryList>();
            Deals = new HashSet<Deals>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string UrlName { get; set; }
        public int AuthorId { get; set; }
        public string BookPhoto { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NumberOfCopies { get; set; }
        public decimal? Price { get; set; }
        public string Photo { get; set; }
        public int CopyYear { get; set; }
        public bool? IsActive { get; set; }
        public string PdfUrl { get; set; }
        public string AduioUrl { get; set; }
        public bool? IsApproved { get; set; }
        public bool ForExchange { get; set; }
        public string BooksToExchange { get; set; }
        public bool ForChildern { get; set; }
        public int? Offer { get; set; }

        public virtual Authors Author { get; set; }
        public virtual ICollection<BookCategoryList> BookCategoryList { get; set; }
        public virtual ICollection<Deals> Deals { get; set; }
    }
}