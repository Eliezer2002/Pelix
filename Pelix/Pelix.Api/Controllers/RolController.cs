using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolRepository rolRepository;

        public RolController(IRolRepository rolRepository)
        {
            this.rolRepository = rolRepository;
        }
        // GET: api/<RolController>
        [HttpGet]
        public IEnumerable<RolModel> Get()
        {
            return rolRepository.GetAll();
        }

        // GET api/<RolController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var rol = rolRepository.GetbyId(id);
           return Ok(rol);
        }

        // POST api/<RolController>
        [HttpPost]
        public IActionResult Post([FromBody] Rol rol)
        {
            rolRepository.Save(rol);
            return Ok();
        }

        // PUT api/<RolController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Rol rol)
        {
            rolRepository.Update(rol);
            return Ok();
        }

        // DELETE api/<RolController>/5
        [HttpDelete()]
        public IActionResult Delete([FromBody] Rol rol)
        {
            rolRepository.Remove(rol);
            return Ok();
        }
    }
}
