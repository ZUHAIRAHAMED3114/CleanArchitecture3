using eShop.UseCases.PlugInInterfaces.DataStore;
using eShop.UseCases.PlugInInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ViewProductScreen
{
   public class AddProdcutToCartUseCase: IAddProductToCartUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCart _shoppingCart;
        public AddProdcutToCartUseCase(IProductRepository productRepository, IShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public async Task Execute(int productId) {

           var product= _productRepository
                        .GetProduct(productId);
            await _shoppingCart.AddProductAsync(product);
        }
    }
}
