using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Orders;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface IOrdersService
    {
        OrdersResponse GetOrdersById(int idOrder);
        IEnumerable<OrdersResponse> GetOrders();

        void InsertOrders(CreateOrdersRequest orders);

        void UpdateOrders(UpdateOrdersRequest orders);

        void DeleteOrders(int idOrder);
    }
}
