using eShop.UseCases.PlugInInterfaces.DataStore;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using System.Threading.Tasks;

namespace eShop.UseCases.ViewProductScreen
{
   public class AddProdcutToCartUseCase: IAddProductToCartUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCart _shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public AddProdcutToCartUseCase(IProductRepository productRepository, 
                                       IShoppingCart shoppingCart,
                                       IShoppingCartStateStore shoppingCartStateStore)  {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task Execute(int productId) {

           var product= _productRepository
                        .GetProduct(productId);
            await _shoppingCart.AddProductAsync(product);
            shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
