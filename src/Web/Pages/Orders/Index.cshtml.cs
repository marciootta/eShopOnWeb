using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private OrderViewModelService _orderViewModelService { get; }
        public IndexModel(OrderViewModelService orderViewModelService)
        {
            _orderViewModelService = orderViewModelService;
        }

        public IEnumerable<OrderViewModel> Ordens { get; set; } = new List<OrderViewModel>();

        public async Task OnGet()
        {
            Ordens = await _orderViewModelService.GetOrdersForUser(User.Identity.Name);
        }
    }
}
