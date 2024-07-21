using CleanArc.Domain.Entities;
using CleanArc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Memory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        public ProductRepository(Context context) 
        {
            _context = context;
        }
        public void Delete(Guid id)
        {
            var _product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (_product != null)
            {
                _context.Products.Remove(_product);
            }
        }

        public List<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var _product = GetById(product.Id);
            _context.Products.Remove(_product);
            Insert(product);

        }
    }
}
