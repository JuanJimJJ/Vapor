using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests;
using VaporApp.Domain.Interfaces;
using VaporApp.Domain.Entities;
using VaporApp.Application.Requests.Products;
using VaporApp.Application.Interfaces;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetUsersByIdRequest request)
        {
            return Ok(_service.GetProductsById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductsRequest request)
        {
            _service.InsertProducts(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateProductsRequest request)
        {
            _service.UpdateProducts(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteProductsRequest request)
        {
            _service.DeleteProducts(request.Id);
            return Ok();
        }
    }
}
