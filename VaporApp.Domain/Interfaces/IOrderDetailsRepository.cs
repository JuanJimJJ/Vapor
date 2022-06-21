using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface IOrderDetailsRepository
    {
        OrderDetails GetOrderDetailsById(int idOrderDetails);
        IEnumerable<OrderDetails> GetOrderDetails();

        void InsertOrderDetails(OrderDetails orderDetails);

        void UpdateOrderDetails(OrderDetails orderDetails);

        void DeleteOrderDetails(int idOrderDetails);
    }
}
