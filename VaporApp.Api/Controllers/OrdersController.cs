using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests.Orders;
using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Application.Interfaces;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _service;

        public OrdersController(IOrdersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetOrders());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetOrdersByIdRequest request)
        {
            return Ok(_service.GetOrdersById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateOrdersRequest request)
        {
            _service.InsertOrders(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateOrdersRequest request)
        {
            _service.UpdateOrders(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteOrdersRequest request)
        {
            _service.DeleteOrders(request.Id);
            return Ok();
        }
    }
}
