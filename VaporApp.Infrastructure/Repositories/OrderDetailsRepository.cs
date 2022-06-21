using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private DBVaporContext _context;
        public OrderDetailsRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetails> GetOrderDetails()
        {
            return _context.OrderDetails;
        }

        public OrderDetails GetOrderDetailsById(int idOrderDetails)
        {
            return _context.OrderDetails.FirstOrDefault(x => x.IdOrderDetails == idOrderDetails);
        }

        public void InsertOrderDetails(OrderDetails orderDetails)
        {
            _context.OrderDetails.Add(orderDetails);
            _context.SaveChanges();
        }

        public void UpdateOrderDetails(OrderDetails orderDetails)
        {
            var orderDetailExisting = _context.OrderDetails.FirstOrDefault(x => x.IdOrderDetails == orderDetails.IdOrderDetails);
            orderDetailExisting.IdOrderDetails = orderDetailExisting.IdOrderDetails;
            orderDetailExisting.DetailAmount = orderDetailExisting.DetailAmount;
            orderDetailExisting.DetailPrice = orderDetailExisting.DetailPrice;
            _context.SaveChanges();
        }

        public void DeleteOrderDetails(int idOrderDetails)
        {
            var orderDetailExisting = _context.OrderDetails.FirstOrDefault(x => x.IdOrderDetails == idOrderDetails);
            _context.OrderDetails.Remove(orderDetailExisting);
            _context.SaveChanges();
        }
    }
}
