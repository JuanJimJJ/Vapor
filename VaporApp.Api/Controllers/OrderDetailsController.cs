using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests.OrderDetails;
using VaporApp.Application.Requests.ProductCategories;
using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Application.Interfaces;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsService _service;

        public OrderDetailsController(IOrderDetailsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetOrderDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetOrderDetailsByIdRequest request)
        {
            return Ok(_service.GetOrderDetailsById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateOrderDetailsRequest request)
        {
            _service.InsertOrderDetails(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateOrderDetailsRequest request)
        {
            _service.UpdateOrderDetails(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteOrderDetailsRequest request)
        {
            _service.DeleteOrderDetails(request.Id);
            return Ok();
        }
    }
}
