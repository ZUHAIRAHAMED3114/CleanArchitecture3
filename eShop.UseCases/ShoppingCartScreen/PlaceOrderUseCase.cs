using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services;
using eShop.CoreBusiness.Services.Interfaces;
using eShop.UseCases.PlugInInterfaces.DataStore;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderServices orderService;
        private readonly IOrderRepository orderRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public PlaceOrderUseCase(IOrderServices orderService,
                                 IOrderRepository orderRepository,
                                 IShoppingCart shoppingCart,
                                 IShoppingCartStateStore shoppingCartStateStore)
        { 
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<string> Execute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                orderRepository.CreateOrder(order);
                await shoppingCart.EmptyAsync();
                shoppingCartStateStore.UpdateLineItemsCount();
                return order.UniqueId;
            }
            return null;
        }
    }
}
