﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace App.Core.Models
{
    public partial class Deals
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string RequestUserId { get; set; }
        public string BookName { get; set; }
        public string BookPhoto { get; set; }
        public int CopyYear { get; set; }

        public virtual Book Book { get; set; }
    }
}