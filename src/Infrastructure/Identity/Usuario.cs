using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class Usuario : IdentityUser
    { 
        [MaxLength(128)]
        public string NomeSogra { get; set; }
    }
}
