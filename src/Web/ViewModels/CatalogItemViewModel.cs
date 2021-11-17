using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.ViewModels
{
    public class CatalogItemViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }
        public string PictureUri { get; set; }
        public decimal Price { get; set; }
    }
}
