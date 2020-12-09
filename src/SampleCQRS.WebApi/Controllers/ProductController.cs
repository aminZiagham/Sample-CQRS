using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleCQRS.Models.Commands;
using SampleCQRS.Models.Queries;

namespace SampleCQRS.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new ProductsListQuery();
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var query = new ProductQueryById(id);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        [HttpPut("{name}")]
        public async Task<IActionResult> Put(string name)
        {
            var command = new ProductCreateCommand(name);
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
