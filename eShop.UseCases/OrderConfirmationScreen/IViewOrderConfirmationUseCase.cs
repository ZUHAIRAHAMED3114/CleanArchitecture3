using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Execute(string UniqueId);
    }
}