using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface IOrdersRepository
    {
        Orders GetOrdersById(int idOrder);
        IEnumerable<Orders> GetOrders();

        void InsertOrders(Orders orders);

        void UpdateOrders(Orders orders);

        void DeleteOrders(int idOrder);
    }
}
