using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Orders
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public decimal Count { get; private set; }
        public decimal Price { get; private set; }
        public decimal TotalPrice => Price * Count;
        public Order(Guid productId, decimal count, decimal price)
        {
            ProductId = productId;
            Count = count;
            Price = price;
            Id = Guid.NewGuid();
        }
    }
}
