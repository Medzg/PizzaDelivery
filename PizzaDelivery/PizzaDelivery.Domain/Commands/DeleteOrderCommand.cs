using System;

namespace PizzaDelivery.Domain.Commands
{
    public class DeleteOrderCommand
    {
        public Guid OrderId { get; }

        public DeleteOrderCommand(Guid orderId)
        {
            this.OrderId = orderId;
        }
    }
}