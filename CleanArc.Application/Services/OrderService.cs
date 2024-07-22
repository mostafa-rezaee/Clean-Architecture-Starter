using CleanArc.Application.DTOs;
using CleanArc.Contract;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ISmsService _smsService;
        public OrderService(IOrderRepository orderRepository, ISmsService smsService)
        {
            _orderRepository = orderRepository;
            _smsService = smsService;
        }

        public void AddOrder(AddOrderDto orderDto)
        {
            var order = new Order(orderDto.ProductId, orderDto.Count, orderDto.Price);
            _orderRepository.Insert(order);
            _orderRepository.SaveChanges();
        }

        public void EditOrder(EditOrderDto orderDto)
        {
            var order = _orderRepository.GetById(orderDto.Id);
            order.Edit(orderDto.ProductId, orderDto.Count, orderDto.Price);
            _orderRepository.Update(order);
            _orderRepository.SaveChanges();
        }

        public void FinalizeOrder(FinalizeOrderDto finalizeOrderDto)
        {
            var order = _orderRepository.GetById(finalizeOrderDto.OrderId);
            order.FinalizeOrder();
            _orderRepository.Update(order);
            _orderRepository.SaveChanges();
            _smsService.SendMessage(new SmsObject { PhoneNumber = "09358660709", Message = "" });
        }

        public OrderDto GetOrderById(Guid id)
        {
            var order = _orderRepository.GetById(id);
            return new OrderDto { 
                Id = id,
                ProductId = order.ProductId,
                Count = order.Count,
                Price = order.Price
            };
        }

        public List<OrderDto> GetOrders()
        {
            return _orderRepository.GetAll().Select(order => new OrderDto {
                Id = order.Id,
                ProductId = order.ProductId,
                Count = order.Count,
                Price = order.Price
            }).ToList();
        }
    }
}
