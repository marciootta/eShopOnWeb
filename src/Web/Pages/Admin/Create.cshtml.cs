using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Services;
using Microsoft.eShopWeb.Web.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private CatalogViewModelService _catalogViewModelService;
        public CreateModel(CatalogViewModelService catalogViewModelService)
        {
            _catalogViewModelService = catalogViewModelService;
        }

        [BindProperty]
        public CatalogItemCreateViewModel Modelo { get; set; } = new CatalogItemCreateViewModel();

        public async Task OnGet()
        {
            await PreencheCombos(Modelo);
        }

        private async Task PreencheCombos(CatalogItemCreateViewModel item)
        {
            Modelo.Brands = (await _catalogViewModelService.GetBrands()).ToList();
            Modelo.Types = (await _catalogViewModelService.GetTypes()).ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _catalogViewModelService.CreateCatalogItem(Modelo);
                return Redirect("/Admin/Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Ocorreu um erro ao inserir.");
                await PreencheCombos(Modelo);
                return Page();
            } 
        }
    }
}
