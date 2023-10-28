using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.CoreBusiness.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<OrderLineItem>();
        }
        public int? OrderId { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateProcessing { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerStateProvinces { get; set; }
        public string CustomerCountry { get; set; }
        public string AdminUser { get; set; }
        public List<OrderLineItem> LineItems { get; set; }
        public string UniqueId { get; set; }


        public void AddProduct(int productId,int qty,double Price) {
            var OrderItems = this.LineItems
                                 .FirstOrDefault(z=>z.ProductId==productId);
            if (OrderItems == null)
            {
                LineItems.Add(new OrderLineItem { ProductId = productId, Quantity = qty, Price = Price });
            }
            else {
                OrderItems.Quantity += qty;
            }
        }

        public void RemoveProduct(int productId) {

              LineItems.RemoveAll(x=>x.ProductId==productId);
        }

        
    }
}
