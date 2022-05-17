using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SharedTenant.Domain;
using Microsoft.EntityFrameworkCore;

namespace SharedTenant.Models
{
    public partial class SharedtenantContext : IdentityDbContext<ApplicationUser>
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ApplicationUser>();
            entity.Property(e => e.Photo)
           .IsRequired(false);

            entity.Property(e => e.Address)
           .IsRequired(false);
            base.OnModelCreating(modelBuilder);


        }
    }
}