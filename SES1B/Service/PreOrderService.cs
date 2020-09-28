using SES1B.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{    public class PreOrderService : IPreOrderService
    {
        // Every Service will have this Irepository
        // Automatically injected during runtime and the config of this will be in the startup.cs
        
        ModelStateDictionary _modelState;
        IRepository _repository;
        public PreOrderService(ModelStateDictionary modelState, IRepository repository)
        {
            _modelState = modelState;
            _repository = repository;
        }

        protected vool ValidateOrderItems(OrderItemsDTO orderItemsDTO)
        {
            if (orderItemsDTO.Quantity == 0){
                _modelState.AddModelError("Quantity", "Quantity is required");
            }
            if (orderItemsDTO.MenuItemId == 0){
                _modelState.AddModelError("MenuItemId", "Menu Item is required");
            }
            return _modelState.IsValid;
        }
        public OrderItemsDTO CreateOrder(OrderItemsDTO orderItemsDTO)
        {
            if(!ValidateOrderItems(OrderItemsDTO orderItemsDTO))
                return false;
            return true;
        }
        
        public OrderItemsDTO EditOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().OrderItems.OrderId == orderItemsDTO.OrderId);
            OrderItems.Quantity = orderItemsDTO.Quantity;
            OrderItems.MenuItemId = orderItemsDTO.MenuItemId;

            return OrderItemsDTO;
        }

        public OrderItemsDTO ViewOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().OrderItems.OrderId == orderItemsDTO.OrderId);
            orderItemsDTO.Quantity = OrderItems.Quantity;
            orderItemsDTO.MenuItemId  = OrderItems.MenuItemId;

            return OrderItemsDTO;
        }

        public OrderItemsDTO DeleteOrder(OrderItemsDTO orderItemsDTO)
        {
            var OrderItems = _repository.GetOrderItems().OrderItems.OrderId == orderItemsDTO.OrderId);
            _repository.OrderItems.remove(OrderItems);

            return OrderItemsDTO;
        }
    }
}