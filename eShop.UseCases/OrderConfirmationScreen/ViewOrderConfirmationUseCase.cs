using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRepository orderRepository;
        public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public Order Execute(string UniqueId)
        {

            return orderRepository.GetOrderByUniqueId(UniqueId);

        }
    }
}
