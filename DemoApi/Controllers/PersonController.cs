using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<Person>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
