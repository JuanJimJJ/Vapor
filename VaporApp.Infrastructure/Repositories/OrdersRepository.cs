using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private DBVaporContext _context;
        public OrdersRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<Orders> GetOrders()
        {
            return _context.Orders;
        }

        public Orders GetOrdersById(int idOrder)
        {
            return _context.Orders.FirstOrDefault(x => x.IdOrder == idOrder);
        }

        public void InsertOrders(Orders orders)
        {
            _context.Orders.Add(orders);
            _context.SaveChanges();
        }

        public void UpdateOrders(Orders orders)
        {
            var orderExisting = _context.Orders.FirstOrDefault(x => x.IdOrder == orders.IdOrder);
            orderExisting.OrderCity = orders.OrderCity;
            orderExisting.OrderZipCode = orders.OrderZipCode;
            orderExisting.OrderCountry = orders.OrderCountry;
            orderExisting.OrderState = orders.OrderState;
            orderExisting.OrderShippingAddress = orders.OrderShippingAddress;
            _context.SaveChanges();
        }

        public void DeleteOrders(int idOrder)
        {
            var orderExisting = _context.Orders.FirstOrDefault(x => x.IdOrder == idOrder);
            _context.Orders.Remove(orderExisting);
            _context.SaveChanges();
        }
    }
}
