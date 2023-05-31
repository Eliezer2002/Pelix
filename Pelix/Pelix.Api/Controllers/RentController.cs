using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IRentRepository rentRepository;

        public RentController(IRentRepository rentRepository)
        {
            this.rentRepository = rentRepository;
        }
        // GET: api/<RentController>
        [HttpGet]
        public IEnumerable<RentModel> Get()
        {
            return rentRepository.GetAll();
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
