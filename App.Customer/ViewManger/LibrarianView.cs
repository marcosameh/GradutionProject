using Microsoft.AspNetCore.Identity;
using SharedTenant.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

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
