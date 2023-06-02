using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using Pelix.DAL.Repositories;
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
        public IActionResult Get()
        {
            var Rents = rentRepository.GetAll();
            return Ok(Rents);
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var rent = rentRepository.GetbyId(id);
            return Ok(rent);
        }

        // POST api/<RentController>
        [HttpPost]
        public IActionResult Post([FromBody] Rent rent)
        {
            rentRepository.Save(rent);
            rentRepository.SaveChanges();
            return Ok();

        }

        // PUT api/<RentController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Rent rent)
        {
            rentRepository.Update(rent);
            rentRepository.SaveChanges();
            return Ok();
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Rent rent)
        {
            rentRepository.Remove(rent);
            rentRepository.SaveChanges();
            return Ok();
        }
    }
}
