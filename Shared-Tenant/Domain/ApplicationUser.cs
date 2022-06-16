using Microsoft.AspNetCore.Identity;
using System;

namespace SharedTenant.Domain
{
    public class ApplicationUser : IdentityUser
    {
      

        [PersonalData]

        public string Photo { get; set; }

        [PersonalData]

        public string Address { get; set; }
    }
}