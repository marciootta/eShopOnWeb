﻿using Microsoft.AspNetCore.Identity;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string NomeDaSogra { get; set; }
    }
}
