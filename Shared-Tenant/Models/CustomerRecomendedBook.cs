﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SharedTenant.Models
{
    public partial class CustomerRecomendedBook
    {
        public string CustomerId { get; set; }
        public int? BookId { get; set; }
        public int Id { get; set; }
        public int? LoveRate { get; set; }

        public virtual BooksForExchange Book { get; set; }
    }
}