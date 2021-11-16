using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Extensions;
using Microsoft.eShopWeb.Web.Services;
using Microsoft.eShopWeb.Web.ViewModels;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Microsoft.eShopWeb.Shared.Authorization;
 
namespace Microsoft.eShopWeb.Web.Pages.Admin
{
    [Authorize(Roles = Microsoft.eShopWeb.Shared.Authorization.Constants.Roles.ADMINISTRATORS)]
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
           
        }
    }
}
