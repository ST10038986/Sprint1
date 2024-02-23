using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sprint1_EpicBookstoreApplication.Models;

namespace Sprint1_EpicBookstoreApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<User> User { get; set; }
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
