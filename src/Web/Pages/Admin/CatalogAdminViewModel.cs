namespace Microsoft.eShopWeb.Web.Pages.Admin
{
    public class CatalogAdminViewModel
{ 
        public int Id { get; set; }
        public string Name { get; set; }
        public string CatalogType { get; set; }
        public string CatalogBrand { get; set; }
        public string PictureUri { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
       
    }
}
