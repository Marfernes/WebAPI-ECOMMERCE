using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_ECOMMERCE.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_RG")]
        public string RG { get; set; }
    }
}
