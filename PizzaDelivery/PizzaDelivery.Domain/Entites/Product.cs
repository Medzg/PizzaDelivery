using System;

namespace PizzaDelivery.Domain.Entites
{
    public class Product
    {
        public Guid Id { get; init; }
        public string ProductName { get; init; }
        public int Quantity { get; init; }
    }
}