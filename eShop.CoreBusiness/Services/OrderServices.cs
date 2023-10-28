using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services.Interfaces;

namespace eShop.CoreBusiness.Services
{
    public class OrderServices : IOrderServices
    {
        public bool ValidateCustomerInformation(string name, string address,
                                                string city, string province,
                                                string country)
        {

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(province) ||
                string.IsNullOrWhiteSpace(country))
            {
                return true;
            }

            return false;

        }

        public bool ValidateCreateOrder(Order order)
        {
            //order has to exist
            if (order == null) return false;

            // order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            // Validating Line Items

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 ||
                   item.Price < 0 ||
                   item.Quantity <= 0)
                    return false;
            }

            if (!ValidateCustomerInformation(order.CustomerName,
                                            order.CustomerAddress,
                                            order.CustomerCity,
                                            order.CustomerStateProvinces,
                                            order.CustomerCountry))
            {
                return false;
            }

            return true;
        }

        public bool VaidateUpdateOrder(Order order)
        {
            if (order == null) return false;

            // order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            //Placed Date has to be Populated During Updaing Order
            if (!order.DatePlaced.HasValue) return false;

            // This is Updated by Later...?
            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

            // There Must be Unique Value Need to There... 
            if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

            if (!ValidateCustomerInformation(order.CustomerName,
                                    order.CustomerAddress,
                                    order.CustomerCity,
                                    order.CustomerStateProvinces,
                                    order.CustomerCountry))
            {
                return false;
            }

            return true;
        }

        public bool ValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue ||
                string.IsNullOrWhiteSpace(order.AdminUser)) return false;

            return true;
        }
    }
}
