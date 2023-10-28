using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Services.Interfaces
{
    public interface IOrderServices
    {
        bool VaidateUpdateOrder(Order order);
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInformation(string name, string address, string city, string province, string country);
        bool ValidateProcessOrder(Order order);
    }
}