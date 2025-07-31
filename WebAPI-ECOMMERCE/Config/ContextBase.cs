using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI_ECOMMERCE.Entities;

namespace WebAPI_ECOMMERCE.Config
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }
        public DbSet<ProductModel> Product { get; set; }
    }

}
