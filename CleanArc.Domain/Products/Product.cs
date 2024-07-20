using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Products
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; } = string.Empty;

        public Product(string title, decimal price, string description)
        {
            Title = title;
            Price = price;
            Description = description;
            Id = Guid.NewGuid();
            
        }

        public void Edit(string title, decimal price, string description)
        {
            Title = title;
            Price = price;
            Description = description;

        }
    }
}
