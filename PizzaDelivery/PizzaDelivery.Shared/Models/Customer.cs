using System;

namespace PizzaDelivery.Shared.Models
{
    public class Customer
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }
    
    }
}