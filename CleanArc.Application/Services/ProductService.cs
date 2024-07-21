using CleanArc.Application.DTOs;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public void AddProduct(AddProductDto productDto)
        {
            var product = new Product(productDto.Title, productDto.Price, productDto.Description);
            _productRepository.Insert(product);
            _productRepository.SaveChanges();
        }

        public void EditProduct(EditProductDto productDto)
        {
            var product = _productRepository.GetById(productDto.Id);
            product.Edit(productDto.Title,productDto.Price,productDto.Description);
            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }

        public ProductDto GetProductDto(Guid id)
        {
            var product = _productRepository.GetById(id);
            return new ProductDto
            {
                Id = id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,

            };
        }

        public List<ProductDto> GetProductDtos()
        {
            return _productRepository.GetAll().Select(p => new ProductDto { Id = p.Id, Title = p.Title, Price = p.Price, Description = p.Description }).ToList();
        }

        public void RemoveProduct(Guid id)
        {
            _productRepository.Delete(id);
            _productRepository.SaveChanges();
        }
    }
}
