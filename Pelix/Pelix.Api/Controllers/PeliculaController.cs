using Microsoft.AspNetCore.Mvc;
using Pelix.BL.Contract;
using Pelix.BL.Dtos.Pelicula;
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
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaService peliculaService;

        public PeliculaController(IPeliculaService peliculaService)
        {
            this.peliculaService = peliculaService;
        }
        // GET: api/<PeliculaController>
        [HttpGet("ObtenerPeliculas")]
        public IActionResult Get()
        {
            var result = peliculaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else 
            {
                return BadRequest(result);
            }

        }

        // GET api/<PeliculaController>/5
        [HttpGet("\"ObtenerPelicula\"{id}")]
        public IActionResult Get(int id)
        {
            var result = peliculaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // POST api/<PeliculaController>
        [HttpPost("GuardarPelicula")]
        public IActionResult Post([FromBody] PeliculaSaveDto pelicula)
        {
            var result = peliculaService.SavePelicula(pelicula);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("ActualizarPelicula")]
        public IActionResult Put([FromBody] PeliculaUpdateDto pelicula)
        {
            var result = peliculaService.UpdatePelicula(pelicula);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("EliminarPelicula")]
        public IActionResult Delete([FromBody] PeliculaRemoveDto id)
        {
            var result = peliculaService.RemovePelicula(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
