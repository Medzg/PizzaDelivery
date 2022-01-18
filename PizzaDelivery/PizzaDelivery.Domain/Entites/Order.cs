using System;

namespace PizzaDelivery.Domain.Entites
{
    public class Order : IAggregateRoot
    {
        public Guid Guid { get; init; }
        public Product Product { get; init; }
        public Customer Customer { get; init; }
    }
}