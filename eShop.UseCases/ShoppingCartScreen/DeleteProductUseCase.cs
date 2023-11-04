using eShop.CoreBusiness.Models;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public DeleteProductUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public async Task<Order> Execute(int ProductId)
        {
            var order = await this.shoppingCart.DeleteProductAsync(ProductId);
            this.shoppingCartStateStore.UpdateLineItemsCount();
            return order;
        }
    }
}
