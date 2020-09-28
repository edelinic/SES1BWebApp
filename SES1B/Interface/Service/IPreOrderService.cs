using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Interface.Service
{
    public interface IPreOrderService
    {
        OrderItemsDTO CreateOrder(OrderItemsDTO orderItemsDTO);
        OrderItemsDTO EditOrder(OrderItemsDTO orderItemsDTO);
        OrderItemsDTO ViewOrder(OrderItemsDTO orderItemsDTO);
        OrderItemsDTO DeleteOrder(OrderItemsDTO orderItemsDTO);             
    }
}