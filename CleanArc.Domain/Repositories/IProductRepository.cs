using CleanArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Repositories
{
    public interface IProductRepository
    {
        Product GetById(Guid id);
        List<Product> GetAll();
        void Insert(Product product);
        void Update(Product product);
        void Delete(Guid id);
        void SaveChanges();
    }
}
