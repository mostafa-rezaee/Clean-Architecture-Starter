using CleanArc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Services
{
    public interface IProductService
    {
        void AddProduct(AddProductDto productDto);
        void EditProduct(EditProductDto productDto);
        void RemoveProduct(Guid id);
        ProductDto GetProductDto(Guid id);
        List<ProductDto> GetProductDtos();
    }
}
