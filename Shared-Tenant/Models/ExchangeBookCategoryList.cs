﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SharedTenant.Models
{
    public partial class ExchangeBookCategoryList
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? CategroyId { get; set; }
        public int? CategoryRate { get; set; }

        public virtual BooksForExchange Book { get; set; }
        public virtual ExchangBookCategory Categroy { get; set; }
    }
}