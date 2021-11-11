using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly OrderViewModelService _orderViewModelService;

        public IndexModel(OrderViewModelService orderViewModelService)
		{
            _orderViewModelService = orderViewModelService;
		}

        public IEnumerable<OrderViewModel> listaOrders { get; set; } = new List<OrderViewModel>();

        public async Task OnGet()
        {
            listaOrders = await _orderViewModelService.GetOrdersAsync(User.Identity.Name);

        }
    }
}
