using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests.Orders;
using VaporApp.Application.Requests;

namespace VaporApp.Application.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _repository;
        private readonly IMapper _mapper;
        public OrdersService(IOrdersRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<OrdersResponse> GetOrders()
        {
            var orders = _repository.GetOrders();
            var ordersResponse = _mapper.Map<IEnumerable<OrdersResponse>>(orders);
            return ordersResponse;
        }

        public OrdersResponse GetOrdersById(int idOrder)
        {
            var orders = _repository.GetOrdersById(idOrder);
            var ordersResponse = _mapper.Map<OrdersResponse>(orders);
            return ordersResponse;
        }

        public void InsertOrders(CreateOrdersRequest request)
        {
            var orders = _mapper.Map<Orders>(request);
            _repository.InsertOrders(orders);
        }

        public void UpdateOrders(UpdateOrdersRequest orders)
        {
            var order = _mapper.Map<Orders>(orders);
            _repository.UpdateOrders(order);
        }

        public void DeleteOrders(int idOrder)
        {
            _repository.DeleteOrders(idOrder);
        }
    }
}
