using System;
using PizzaDelivery.Domain.Commands;

namespace PizzaDelivery.Domain.Entites
{
    public class Order : IAggregateRoot
    {
        public Guid Id { get; init; }
        public Product Product { get; init; }
        public Customer Customer { get; init; }

        public Order()
        {
            
        }
        public Order  CreateOrder(CreateOrderCommand orderCommand)
        {
            //ToDo : when create an order look for the customer and produtId
            return this;
        }
    }
}