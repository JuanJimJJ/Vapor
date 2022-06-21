using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaporApp.Application.Requests;
using VaporApp.Domain.Interfaces;
using VaporApp.Domain.Entities;
using VaporApp.Application.Requests.Users;
using VaporApp.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace VaporApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /*[Authorize]
    [Produces("application/json")]*/
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetUsersByIdRequest request)
        {
            return Ok(_service.GetUsersById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateUsersRequest request)
        {
            _service.InsertUsers(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateUsersRequest request)
        {
            _service.UpdateUsers(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteUsersRequest request)
        {
            _service.DeleteUsers(request.Id);
            return Ok();
        }
    }
}
