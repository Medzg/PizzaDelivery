using System;

namespace PizzaDelivery.Shared.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}