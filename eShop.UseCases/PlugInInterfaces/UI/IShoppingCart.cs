﻿using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.PlugInInterfaces.UI
{
    public interface IShoppingCart
    {
        Task<Order> GetOrderAsync();
        Task<Order> AddProductAsync(Product product);
        Task<Order> UpdateQuantityAsync(int productId,int quantity);
        Task<Order> UpdateOrderAsync(Order order);
        Task<Order> DeleteProductAsync(int ProductId);
        Task EmptyAsync();
    }
}
