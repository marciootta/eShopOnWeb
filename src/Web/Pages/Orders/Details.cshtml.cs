using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.eShopWeb.Web.Services;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private OrderViewModelService _orderViewModelService { get; }
        public DetailsModel(OrderViewModelService orderViewModelService)
        {
            _orderViewModelService = orderViewModelService;
        }


        public OrderViewModel Order { get; set; }

        public async Task OnGet(int orderId)
        {
            Order = await _orderViewModelService.GetOrderDetailsForUser(User.Identity.Name, orderId);
        }
    }
}
