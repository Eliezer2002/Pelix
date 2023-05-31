using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IGeneroRepository generoRepository;

        public GenerosController(IGeneroRepository generoRepository)
        {
            this.generoRepository = generoRepository;
        }
        // GET: api/<GenerosController>
        [HttpGet]
        public IEnumerable<GenerosModel> Get()
        {
            return generoRepository.GetAll();
        }

        // GET api/<GenerosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenerosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenerosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenerosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
