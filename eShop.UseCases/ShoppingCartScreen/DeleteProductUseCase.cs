﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public DeleteProductUseCase(IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int ProductId)
        {
            var order = await this.shoppingCart.DeleteProductAsync(ProductId);
            this.shoppingCartStateStore.UpdateLineItemsCount();
            return order;
        }
    }
}
