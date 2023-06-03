using Microsoft.AspNetCore.Mvc;
using Pelix.BL.Contract;
using Pelix.BL.Dtos.Rol;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using Pelix.DAL.Repositories;
using System.Collections;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService rolService;

        public RolController(IRolService rolService)
        {
            this.rolService = rolService;
        }
        // GET: api/<RolController>
        [HttpGet("ObtenerRols")]
        public IActionResult Get()
        {
            var result = rolService.GetAll();
            if (result.Success) 
            { 
                return Ok(result);
            }
            else
            {
                return BadRequest();
            } 
        }

        // GET api/<RolController>/5
        [HttpGet("\"ObtenerRol\"{id}")]
        public IActionResult Get(int id)
        {
            var result = rolService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<RolController>
        [HttpPost("GuardarRol")]
        public IActionResult Post([FromBody] RolSaveDto rol)
        {
            var result = rolService.SaveRol(rol);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<RolController>/5
        [HttpPut("ActualizarRol")]
        public IActionResult Put([FromBody] RolUpdateDto rol)
        {
            var result = rolService.UpdateRol(rol);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<RolController>/5
        [HttpDelete("EliminarRol")]
        public IActionResult Delete([FromBody] RolRemoveDto rol)
        {
            var result = rolService.RemoveRol(rol);
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
