using System.Collections;

namespace MWebStore.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(int quantity, decimal price)
        {
            this.Quantity = quantity;
            this.Price = price;
        }

        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }
    }
}