using Microsoft.AspNetCore.Mvc;
using Pelix.BL.Contract;
using Pelix.BL.Dtos.Rent;
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
        private readonly IRentService rentService;

        public RentController(IRentService rentService)
        {
            this.rentService = rentService;
        }
        // GET: api/<RentController>
        [HttpGet ("ObtenerRents")]
        public IActionResult Get()
        {
            var result = rentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else 
            { 
                return BadRequest(); 
            }
        }

        // GET api/<RentController>/5
        [HttpGet("\"ObtenerRents\"{id}")]
        public IActionResult Get(int id)
        {
            var result = rentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<RentController>
        [HttpPost("GuardarRent")]
        public IActionResult Post([FromBody] RentSaveDto rent)
        {
            var result = rentService.SaveRent(rent);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }

        // PUT api/<RentController>/5
        [HttpPut("ActualizarRent")]
        public IActionResult Put([FromBody] RentUpdateDto rent)
        {
            var result = rentService.UpdateRent(rent);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<RentController>/5
        [HttpDelete("EliminarRent")]
        public IActionResult Delete([FromBody] RentRemoveDto rent)
        {
            var result = rentService.RemoveRent(rent);
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
