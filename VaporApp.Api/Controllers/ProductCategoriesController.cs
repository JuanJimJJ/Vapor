using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests.ProductCategories;
using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Application.Interfaces;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoriesService _service;

        public ProductCategoriesController(IProductCategoriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetProductCategories());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetProductCategoriesByIdRequest request)
        {
            return Ok(_service.GetProductCategoriesById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductCategoriesRequest request)
        {
            _service.InsertProductCategories(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateProductCategoriesRequest request)
        {
            _service.UpdateProductCategories(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteProductCategoriesRequest request)
        {
            _service.DeleteProductCategories(request.Id);
            return Ok();
        }
    }
}
