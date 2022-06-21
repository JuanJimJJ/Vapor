using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.OrderDetails;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface IOrderDetailsService
    {
        OrderDetailsResponse GetOrderDetailsById(int idOrderDetail);
        IEnumerable<OrderDetailsResponse> GetOrderDetails();

        void InsertOrderDetails(CreateOrderDetailsRequest orderDetails);

        void UpdateOrderDetails(UpdateOrderDetailsRequest orderDetails);

        void DeleteOrderDetails(int idOrderDetail);
    }
}
