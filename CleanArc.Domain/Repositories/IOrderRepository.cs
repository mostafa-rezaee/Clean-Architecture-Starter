using CleanArc.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Repositories
{
    public  interface IOrderRepository
    {
        Order GetById(Guid id);
        List<Order> GetAll();
        void Insert(Order order);
        void Update(Order order);

    }
}
