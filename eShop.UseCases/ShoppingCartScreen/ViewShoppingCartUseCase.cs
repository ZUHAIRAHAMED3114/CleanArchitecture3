using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.UI;
using System.Threading.Tasks;
using eShop.UseCases.ShoppingCartScreen.Interfaces;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public Task<Order> Execute()
        {

            return shoppingCart.GetOrderAsync();

        }
    }
}
