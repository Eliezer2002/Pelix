using Microsoft.AspNetCore.Mvc;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return userRepository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = userRepository.GetbyId(id);
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            userRepository.Save(user);
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] User user)
        {
            userRepository.Update(user);
            return Ok();
        }

        // DELETE api/<UserController>/5
        [HttpDelete()]
        public IActionResult Delete([FromBody] User id)
        {
            userRepository.Remove(id);
            return Ok();
        }
    }
}
