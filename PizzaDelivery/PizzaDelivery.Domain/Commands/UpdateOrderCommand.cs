using System;

namespace PizzaDelivery.Domain.Commands
{
    public class UpdateOrderCommand
    {
        public Guid OrderId { get;}
        public Guid ProductId { get; }
        public Guid CustomId { get; }
        public int Quantity { get; }

        public UpdateOrderCommand(Guid orderId,Guid productId, Guid customId, int quantity )
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.CustomId = customId;
            this.Quantity = quantity;
        }
    }
}