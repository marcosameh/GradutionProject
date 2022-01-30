﻿using App.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public partial class KitabiContext : IdentityDbContext<ApplicationUser>
    {
        public override DbSet<ApplicationUser> Users { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            var entity = modelBuilder.Entity<ApplicationUser>();
            


            entity.Property(e => e.Photo)
           .IsRequired(false);




            base.OnModelCreating(modelBuilder);


        }

    }
}
