using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore.HardCoded
{
    public class OrderRepository : IOrderRepository
    {
        Dictionary<int, Order> _orders;
        public OrderRepository()
        {
            _orders = new Dictionary<int, Order>();
        }
        public int CreateOrder(Order order)
        {
            order.OrderId = _orders.Count + 1;
            _orders.Add( order.OrderId.Value,order);
            return order.OrderId.Value;
        }

        public IEnumerable<OrderLineItem> GetLineItemsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            return _orders[id];
        }

        public IEnumerable<Order> GetOrder()
        {
            return _orders.Values;
        }

        public Order GetOrderByUniqueId(string UniqueId)
        {
            return _orders.Values.FirstOrDefault(x => x.UniqueId==UniqueId);
        }

        public IEnumerable<Order> GetOutStandingOrder()
        {
            return _orders.Values.ToList().Where(x => !x.DateProcessed.HasValue);
          
        }

        public IEnumerable<Order> GetProcessedOrder()
        {
            return _orders.Values.ToList().Where(x => x.DateProcessed.HasValue);
        }

        public void UpdateOrder(Order order)
        {
            if (order == null || !order.OrderId.HasValue) return;
            var oldOrder = _orders[order.OrderId.Value];
            if (oldOrder == null) return;

            _orders[oldOrder.OrderId.Value] = order;
        }
    }
}
