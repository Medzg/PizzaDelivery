using System;

namespace PizzaDelivery.Domain.Commands
{
    public class CreateOrderCommand
    {
        public Guid ProductId { get; }
        public Guid CustomId { get; }
        public int Quantity { get; }

        public CreateOrderCommand(Guid productId, Guid customId, int quantity )
        {
            this.ProductId = productId;
            this.CustomId = customId;
            this.Quantity = quantity;
        }
    }
}