﻿using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class UpdateQuantityUseCase : IUpdateQuantityUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public UpdateQuantityUseCase(IShoppingCart shoppingCart,
                                     IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId, int quantity)
        {

            var order = await shoppingCart.UpdateQuantityAsync(productId, quantity);
            shoppingCartStateStore.UpdateProductQuantity();
            return order;
        }
    }
}
