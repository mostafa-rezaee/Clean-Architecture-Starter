using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public decimal Count { get; private set; }
        public decimal Price { get; private set; }
        public bool IsFinall { get; private set; }
        public DateTime FinallDate { get; private set; }
        public decimal TotalPrice => Price * Count;
        public Order(Guid productId, decimal count, decimal price)
        {
            ProductId = productId;
            Count = count;
            Price = price;
            Id = Guid.NewGuid();
        }
        public void Edit(Guid productId, decimal count, decimal price)
        {
            ProductId = productId;
            Count = count;
            Price = price;
        }

        public void FinalizeOrder()
        {
            IsFinall = true;
            FinallDate = DateTime.Now;
        }

        public void IncreaseCount(decimal count)
        {
            Count = +count;
        }
    }
}
