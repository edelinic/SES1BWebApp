using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Entity;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{
    public class OrderService : IOrderService
    {
      // Every Service will have this Irepository
        // Automatically injected during runtime and the config of this will be in the startup.cs
        
        IRepository _repository;
        public OrderService(IRepository repository)
        {
            _repository = repository;
        }

        public OrderDTO CreateOrder(OrderDTO orderDTO)
        {
            var order = new Order() {
            };

            _repository.PostOrder(order);
            orderDTO.OrderId = order.OrderId;
            orderDTO.BookingId = order.BookingId;
            return orderDTO;
        }

        public OrderDTO EditOrder(OrderDTO orderDTO)
        {
            var Order = _repository.GetOrders().WithOrderId(orderDTO.OrderId);

            Order.OrderId = orderDTO.OrderId;
            Order.BookingId = orderDTO.BookingId;
            _repository.PostOrder(Order);
            
            return orderDTO;
        }

        public OrderDTO ViewOrder(OrderDTO orderDTO)
        {
            var Order = _repository.GetOrders().WithOrderId(orderDTO.OrderId);
            orderDTO.OrderId = Order.OrderId;
            orderDTO.BookingId  = Order.BookingId;

            return orderDTO;
        }

        public OrderDTO DeleteOrder(OrderDTO orderDTO)
        {
            var Order = _repository.GetOrders().WithOrderId(orderDTO.OrderId);
            _repository.RemoveOrder(Order);

            return orderDTO;
        }
    }
}
