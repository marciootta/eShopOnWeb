using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Identity.Config
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(p => p.NomeDaSogra).HasMaxLength(100).HasColumnType("varchar(100");
        }
    }
}
