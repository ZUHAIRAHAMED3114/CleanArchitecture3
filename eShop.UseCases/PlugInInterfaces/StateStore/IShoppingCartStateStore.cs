using System.Threading.Tasks;

namespace eShop.UseCases.PlugInInterfaces.StateStore
{
    public interface IShoppingCartStateStore:IStateStore
    {
        Task<int> GetItemsCount();
        void UpdateLineItemsCount();
        void UpdateProductQuantity();
    }
}
