using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.DTOs
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public decimal Count { get; set; }
        public decimal Price { get; set; }
    }

    public class AddOrderDto
    {
        public Guid ProductId { get; set; }
        public decimal Count { get; set; }
        public decimal Price { get; set; }
    }

    public class EditOrderDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public decimal Count { get; set; }
        public decimal Price { get; set; }
    }

    public class FinalizeOrderDto
    {
        public Guid OrderId { get; set; }
    }
}
