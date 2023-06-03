using Microsoft.AspNetCore.Mvc;
using Pelix.BL.Contract;
using Pelix.BL.Dtos.User;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet("ObtenerUser")]
        public IActionResult Get()
        {
            var result = userService.GetAll();
            if (result.Success) 
            { 
                return Ok(result);
            }
            else 
            { 
                return BadRequest(); 
            }
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = userService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserSaveDto user)
        {
            var result = userService.SaveUser(user);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] UserUpdateDto user)
        {
            var result = userService.UpdateUser(user);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete()]
        public IActionResult Delete([FromBody] UserRemoveDto id)
        {
            var result = userService.RemoveUser(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
