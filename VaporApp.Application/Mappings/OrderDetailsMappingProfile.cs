using VaporApp.Application.Requests.OrderDetails;
using VaporApp.Domain.Entities;
using AutoMapper;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Mappings
{
    class OrderDetailsMappingProfile : Profile
    {
        public OrderDetailsMappingProfile()
        {
            CreateMap<CreateOrderDetailsRequest, OrderDetails>();
            CreateMap<OrderDetails, CreateOrderDetailsRequest>();

            CreateMap<UpdateOrderDetailsRequest, OrderDetails>();
            CreateMap<OrderDetails, UpdateOrderDetailsRequest>();

            CreateMap<OrderDetails, OrderDetailsResponse>();
        }
    }
}
