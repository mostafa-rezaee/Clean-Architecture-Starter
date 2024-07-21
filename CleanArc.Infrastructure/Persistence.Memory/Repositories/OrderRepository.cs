using CleanArc.Domain.Entities;
using CleanArc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Memory.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;
        public OrderRepository(Context context)
        {
            _context = context;
        }
        public List<Order> GetAll()
        {
            return _context.Orders;
        }

        public Order GetById(Guid id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
        }

        public void SaveChanges()
        {
            
        }

        public void Update(Order order)
        {
            var _order = GetById(order.Id);
            _context.Orders.Remove(_order);
            Insert(order);
        }
    }
}
