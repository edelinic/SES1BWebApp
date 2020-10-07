using SES1B.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Interface.Service
{
    public interface IOrderService
    {
        OrderDTO CreateOrder(OrderDTO orderDTO);
        OrderDTO EditOrder(OrderDTO orderDTO);
        OrderDTO ViewOrder(OrderDTO orderDTO);
        OrderDTO DeleteOrder(OrderDTO orderDTO);             
    }
}