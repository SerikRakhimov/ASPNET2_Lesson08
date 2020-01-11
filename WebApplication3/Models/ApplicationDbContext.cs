using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Car> Cars { get; set; }
//      public override DbSet<User> Users { get; set; }
        public override IDbSet<ApplicationUser> Users { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}