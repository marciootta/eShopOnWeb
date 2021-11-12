using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications
{
    public class CatalogWithBrandTypeSpecification : Specification<CatalogItem>
    {
        public CatalogWithBrandTypeSpecification()
        {
            Query.Include(c=> c.CatalogBrand)
                 .Include(c=>c.CatalogType);

        }
    }
}
