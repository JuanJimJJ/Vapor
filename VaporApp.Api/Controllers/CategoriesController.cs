using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests;
using VaporApp.Domain.Interfaces;
using VaporApp.Domain.Entities;
using VaporApp.Application.Requests.Categories;
using VaporApp.Application.Interfaces;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _service;

        public CategoriesController(ICategoriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetCategories());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetCategoriesByIdRequest request)
        {
            return Ok(_service.GetCategoriesById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateCategoriesRequest request)
        {
            _service.InsertCategories(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateCategoriesRequest request)
        {
            _service.UpdateCategories(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteCategoriesRequest request)
        {
            _service.DeleteCategories(request.Id);
            return Ok();
        }
    }
}
