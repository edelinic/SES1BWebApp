using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{    
    public class OrderItemsService : IOrderItemsService
    {
        // Every Service will have this Irepository
        // Automatically injected during runtime and the config of this will be in the startup.cs
        
        IRepository _repository;
        public OrderItemsService(IRepository repository)
        {
            _repository = repository;
        }

        protected bool ValidateOrderItems(OrderItemsDTO orderItemsDTO)
        {
            if (orderItemsDTO.Quantity == null)
            {

            }
            if (orderItemsDTO.MenuItemId == null)
            {
                
            }
            return true;
        }
        public OrderItemsDTO CreateOrder(OrderItemsDTO orderItemsDTO)
        {
            _repository.GetOrderItems().Add(OrderId);
            _dataContext.SaveChanges();
            return OrderId;
        }
        
        public OrderItemsDTO EditOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().WithOrderItemsId(orderItemsDTO.OrderId);

            if (ValidateOrderItems(orderItemsDTO))
            {
                OrderItems.Quantity = orderItemsDTO.Quantity;
                OrderItems.MenuItemId = orderItemsDTO.MenuItemId;
            }
            
            return orderItemsDTO;
        }

        public OrderItemsDTO ViewOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().WithOrderItemsId(orderItemsDTO.OrderId);
            orderItemsDTO.Quantity = OrderItems.Quantity;
            orderItemsDTO.MenuItemId  = OrderItems.MenuItemId;

            return orderItemsDTO;
        }

        public OrderItemsDTO DeleteOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().WithOrderItemsId(orderItemsDTO.OrderId);
            OrderItems.remove(OrderItems);

            return orderItemsDTO;
        }
    }
}