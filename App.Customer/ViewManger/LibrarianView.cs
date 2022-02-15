using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using App.Core.Domain;

namespace App.Customer.ViewManger
{
    public class LibrarianView
    {
        private readonly UserManager<ApplicationUser> user;

        public LibrarianView(UserManager<ApplicationUser> user)
        {
            this.user = user;
        }
        public async Task<IEnumerable<ApplicationUser>> GetAll_Librarians()
        {
            return await user.GetUsersInRoleAsync("Librarian");
        }
    }
}
