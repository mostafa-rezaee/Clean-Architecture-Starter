using CleanArc.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Money Price { get; set; }
        public string Description { get; set; }
    }

    public class AddProductDto
    {
        public string Title { get; set; }
        public Money Price { get; set; }
        public string Description { get; set; }
    }

    public class EditProductDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Money Price { get; set; }
        public string Description { get; set; }
    }
}
