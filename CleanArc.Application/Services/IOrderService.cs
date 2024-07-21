using CleanArc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Services
{
    public interface IOrderService
    {
        void AddOrder(AddOrderDto orderDto);
        void EditOrder(EditOrderDto orderDto);
        void FinalizeOrder(FinalizeOrderDto finalizeOrderDto);
        OrderDto GetOrderDto(Guid id);
        List<OrderDto> GetOrderDtos();
    }
}
