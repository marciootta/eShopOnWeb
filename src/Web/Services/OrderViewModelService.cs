using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.ApplicationCore.Specifications;
using Microsoft.eShopWeb.Web.Pages.Orders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Web.Services
{
    public class OrderViewModelService
    {
        private readonly IAsyncRepository<Order> _orderRepository;

        public OrderViewModelService(IAsyncRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public async Task<IEnumerable<OrderViewModel>> GetOrdersForUser(string userName)
        {
            var orderSpec = new CustomerOrdersWithItemsSpecification(userName);
            var ordens = (await _orderRepository.ListAsync(orderSpec));

            var listaOrderViewModel = ordens.Select(o => new OrderViewModel
            {
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems?.Select(oi => new OrderItemViewModel()
                {
                    PictureUrl = oi.ItemOrdered.PictureUri,
                    ProductId = oi.ItemOrdered.CatalogItemId,
                    ProductName = oi.ItemOrdered.ProductName,
                    UnitPrice = oi.UnitPrice,
                    Units = oi.Units
                }).ToList(),
                OrderNumber = o.Id,
                ShippingAddress = o.ShipToAddress,
                Total = o.Total()
            });

            return listaOrderViewModel;
        }

        public async Task<OrderViewModel> GetOrderDetailsForUser(string userName, int orderId)
        {
            var orderSpec = new CustomerOrdersWithItemsSpecification(userName);                                     // aula3finish
            var ordens = (await _orderRepository.ListAsync(orderSpec));
            var order = ordens.FirstOrDefault(o => o.Id == orderId);
            return new OrderViewModel
            {
                OrderDate = order.OrderDate,
                OrderItems = order.OrderItems?.Select(oi => new OrderItemViewModel()
                {
                    PictureUrl = oi.ItemOrdered.PictureUri,
                    ProductId = oi.ItemOrdered.CatalogItemId,
                    ProductName = oi.ItemOrdered.ProductName,
                    UnitPrice = oi.UnitPrice,
                    Units = oi.Units
                }).ToList(),
                OrderNumber = order.Id,
                ShippingAddress = order.ShipToAddress,
                Total = order.Total()
            };
             
        }
    }
}
