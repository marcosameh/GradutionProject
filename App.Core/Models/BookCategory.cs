﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace App.Core.Models
{
    public partial class BookCategory
    {
        public BookCategory()
        {
            BookCategoryList = new HashSet<BookCategoryList>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<BookCategoryList> BookCategoryList { get; set; }
    }
}