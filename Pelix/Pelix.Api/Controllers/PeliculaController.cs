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
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaRepository peliculaRepository;

        public PeliculaController(IPeliculaRepository _peliculaRepository)
        {
            peliculaRepository = _peliculaRepository;
        }
        // GET: api/<PeliculaController>
        [HttpGet]
        public IActionResult Get()
        {
            var peliculas = peliculaRepository.GetAll();
            return Ok(peliculas);
        }

        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pelicula = peliculaRepository.GetbyId(id);
            return Ok(pelicula);
        }

        // POST api/<PeliculaController>
        [HttpPost]
        public IActionResult Post([FromBody] Pelicula pelicula)
        {
            peliculaRepository.Save(pelicula);
            return Ok();
        }

        // PUT api/<PeliculaController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Pelicula pelicula)
        {
            peliculaRepository.Update(pelicula);
            return Ok();
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] Pelicula id)
        {
            peliculaRepository.Remove(id);
            return Ok();
        }
    }
}
