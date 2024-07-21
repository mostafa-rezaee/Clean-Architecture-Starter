using CleanArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Memory
{
    public class Context
    {
        public List<Product> Products{ get; set; }
        public List<Order> Orders { get; set; }
    }
}
