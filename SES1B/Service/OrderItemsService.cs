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
            if (orderItemsDTO.Quantity == 0)
            {
                return false;
            }
            if (orderItemsDTO.MenuItemId == 0)
            {
                return false;
            }
            return true;
        }

        public OrderItemsDTO CreateOrder(OrderItemsDTO orderItemsDTO)
        {
            if (ValidateOrderItems(orderItemsDTO))
            {
                var orderitem = new Orderitems() {
                    Quantity = orderItemsDTO.Quantity,
                    OrderId = orderItemsDTO.OrderId,
                    MenuItemId = orderItemsDTO.MenuItemId
                };

                _repository.PostOrderItems(orderitem);
                orderItemsDTO.OrderId = orderitem.OrderId;
            }

            return orderItemsDTO;
        }
        
        public OrderItemsDTO EditOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().WithOrderItemsId(orderItemsDTO.OrderId);

            if (ValidateOrderItems(orderItemsDTO))
            {
                OrderItems.Quantity = orderItemsDTO.Quantity;
                OrderItems.MenuItemId = orderItemsDTO.MenuItemId;
                _repository.PostOrderItems(OrderItems);
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
            _repository.RemoveOrderItems(OrderItems);

            return orderItemsDTO;
        }
    }
}