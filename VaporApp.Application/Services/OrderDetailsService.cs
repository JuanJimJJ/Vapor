using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests.OrderDetails;
using VaporApp.Application.Requests;

namespace VaporApp.Application.Services
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _repository;
        private readonly IMapper _mapper;
        public OrderDetailsService(IOrderDetailsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<OrderDetailsResponse> GetOrderDetails()
        {
            var orderDetails = _repository.GetOrderDetails();
            var orderDetailsResponse = _mapper.Map<IEnumerable<OrderDetailsResponse>>(orderDetails);
            return orderDetailsResponse;
        }

        public OrderDetailsResponse GetOrderDetailsById(int idOrderDetail)
        {
            var orderDetails = _repository.GetOrderDetailsById(idOrderDetail);
            var orderDetailsResponse = _mapper.Map<OrderDetailsResponse>(orderDetails);
            return orderDetailsResponse;
        }

        public void InsertOrderDetails(CreateOrderDetailsRequest request)
        {
            var orderDetails = _mapper.Map<OrderDetails>(request);
            _repository.InsertOrderDetails(orderDetails);
        }

        public void UpdateOrderDetails(UpdateOrderDetailsRequest orderDetails)
        {
            var orderDetail = _mapper.Map<OrderDetails>(orderDetails);
            _repository.UpdateOrderDetails(orderDetail);
        }

        public void DeleteOrderDetails(int idOrderDetail)
        {
            _repository.DeleteOrderDetails(idOrderDetail);
        }
    }
}
