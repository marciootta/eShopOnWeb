using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Extensions;
using Microsoft.eShopWeb.Web.Services;
using Microsoft.eShopWeb.Web.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Microsoft.eShopWeb.Shared.Authorization;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopWeb.Web.Pages.Admin
{
    [Authorize(Roles = Microsoft.eShopWeb.Shared.Authorization.Constants.Roles.ADMINISTRATORS)]
    public class IndexModel : PageModel
    {

        CatalogItemViewModelService _catalogItemViewModelService;

        public IndexModel(CatalogItemViewModelService catalogItemViewModelService)
        {
           _catalogItemViewModelService = catalogItemViewModelService;
        }
        public IEnumerable<CatalogAdminViewModel> Lista = new List<CatalogAdminViewModel>();

        public async Task OnGet()
        {
            Lista = await _catalogItemViewModelService.GetAllCatalogItems();
        }
        public  IActionResult OnPostDelete(int id)
        {
             

            return RedirectToPage();
        }
    }
}
