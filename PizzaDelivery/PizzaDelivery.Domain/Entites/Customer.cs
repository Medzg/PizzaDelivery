using System;

namespace PizzaDelivery.Domain.Entites
{
    public class Customer
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }

        public Customer(string name, string lastName, string address)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.LastName = lastName;
            this.Address = address;

        }
    }
}