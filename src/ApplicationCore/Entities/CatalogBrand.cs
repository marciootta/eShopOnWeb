using Microsoft.eShopWeb.ApplicationCore.Interfaces;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class CatalogBrand : BaseEntity, IAggregateRoot
    {
        public string Brand { get; private set; }
        public string Notes { get; private set; }

        public CatalogBrand(string brand, string notes=null)
        {
            Brand = brand;
            Notes = notes;
        }
    }
}
