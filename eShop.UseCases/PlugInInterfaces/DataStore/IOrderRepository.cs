
using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.PlugInInterfaces.DataStore
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
        Order GetOrderByUniqueId(string UniqueId);
        int CreateOrder(Order order);
        void UpdateOrder(Order order);
        IEnumerable<Order> GetOrder();
        IEnumerable<Order> GetOutStandingOrder();
        IEnumerable<Order> GetProcessedOrder();
        IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId);
    }

}
