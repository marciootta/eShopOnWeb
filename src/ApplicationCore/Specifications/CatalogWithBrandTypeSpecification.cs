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
        public CatalogWithBrandTypeSpecification(int? brandId, int? typeId)
        {
            Query.Where(i => (!brandId.HasValue || i.CatalogBrandId == brandId) &&
                (!typeId.HasValue || i.CatalogTypeId == typeId));
            Query.Include(c => c.CatalogBrand);
            Query.Include(c=>c.CatalogType);
        }
    }
}
