using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.DataStore;
using eShop.UseCases.PlugInInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private const string cstrShoppingCart = "eShop.ShoppingCart";
        private readonly IJSRuntime jSRuntime;
        private readonly IProductRepository productRepository;

        public ShoppingCart(IProductRepository productRepository, IJSRuntime jSRuntime)
        {
            this.productRepository = productRepository;
            this.jSRuntime = jSRuntime;
        }

        public async Task<Order> AddProductAsync(Product product)
        {
            Console.WriteLine($"Adding Product Whose Product Id {product.Id}");
            var order = await GetOrder();
            // This is 
            order.AddProduct(product.Id,1,product.Price);
            await SetOrder(order);
            return order;
        }

        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.RemoveProduct(productId);
            await SetOrder(order);
            return order;
        }

        public Task EmptyAsync()
        {
            return SetOrder(null);
        }

        public Task<Order> GetOrderAsync()
        {
            return GetOrder();
        }

        public Task<Order> UpdateOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quantity)
        {
            var order = await GetOrder();
            if (quantity < 0) return order;
            else if (quantity == 0) return await DeleteProductAsync(productId);
            var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
            if (lineItem != null) {
                lineItem.Quantity = quantity;
            }
            return order;
        }

        private async Task<Order> GetOrder() {
            Order order = null;
            var strOrder = await jSRuntime
                               .InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);
            if (!string.IsNullOrWhiteSpace(strOrder) && strOrder.ToLower()!="null")
            {
                order = JsonConvert.DeserializeObject<Order>(strOrder);
            }
            else {
                order = new Order();
                await SetOrder(order);
            }

            foreach (var item in order.LineItems) {
                item.Product = productRepository.GetProduct(item.ProductId);
            }
         

            return order;
        }

        private async Task SetOrder(Order order) {

           
            await jSRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
            await jSRuntime.InvokeVoidAsync("console.log", "Order stored in local storage:", order);
        }
    }
}
