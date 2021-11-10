using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    { 
        [MaxLength(128)]
        public string NomeSogra { get; set; }
    }
}
