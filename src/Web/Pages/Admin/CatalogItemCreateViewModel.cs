using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.Pages.Admin
{
    public class CatalogItemCreateViewModel
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Name { get; set; }
        public string Description { get; private set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Type é obrigatório")]
        public int CatalogTypeId { get; set; }

        [Display(Name ="Brand")]
        [Required(ErrorMessage = "Brand é obrigatório")]
        public int CatalogBrandId { get;  set; }
        
        [Display(Name="URL da imagem")]
        public string PictureUri { get; set; }
        [Required(ErrorMessage = "Preço é obrigatório")]
        [Range(minimum:0.01d, maximum:999d, ErrorMessage ="Faixa de valor inválida")]
        public decimal Price { get; set; }
        public List<SelectListItem> Brands { get; set; }
        public List<SelectListItem> Types { get; set; }
    }
}
